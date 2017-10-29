/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   asm.c                                              :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: hmassonn <hmassonn@student.42.fr>          +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2017/02/10 13:43:50 by hmassonn          #+#    #+#             */
/*   Updated: 2017/10/23 14:31:17 by hmassonn         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "op.h"

void	print_option(t_header *head, t_inst *champ, t_intmain itm, char *new)
{
	if (itm.opt == 0)
	{
		fill_file(itm.fd, head, champ);
		ft_putstr("Writing output program to ");
		ft_putendl(new);
	}
	else
	{
		ft_putendl("Dumping annotated program on standard output");
		ft_putstr("Program size: ");
		ft_putnbr(head->prog_size);
		ft_putchar('\n');
		print_header(head);
		print_champ(champ);
	}
}

void	open_it(t_intmain *itm, char *name, t_inst *champ, t_header *head)
{
	char		*new;

	new = s_to_cor(name);
	if (close(itm->fd) || (itm->fd = open(new, O_CREAT | O_WRONLY, 0777)) < 1)
		ft_error("Can't creat file core");
	print_option(head, champ, *itm, new);
	close(itm->fd);
	free(new);
}

void	ft_asm(char *name)
{
	t_header	*head;
	t_inst		*champ;
	t_intmain	itm;

	head = NULL;
	init_header(&head);
	itm.i = 1;
	itm.opt = 0;
	itm.opt = !ft_strcmp(name, "-a") ? 1 : itm.opt;
	if (ft_strcmp(name, "-a"))
	{
		champ = NULL;
		if ((itm.fd = open(name, O_RDONLY)) < 1)
			ft_error("Can't read source file core");
		get_line(itm.fd, &champ, head);
		open_it(&itm, name, champ, head);
		free_champ(&champ);
	}
	free(head);
}
