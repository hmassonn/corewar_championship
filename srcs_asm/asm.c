/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   asm.c                                              :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: hmassonn <hmassonn@student.42.fr>          +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2017/02/10 13:43:50 by hmassonn          #+#    #+#             */
/*   Updated: 2017/10/23 13:49:13 by hmassonn         ###   ########.fr       */
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

void	open_it(t_intmain *itm, char **av, t_inst *champ, t_header *head)
{
	char		*new;

	new = s_to_cor(av[itm->i]);
	if (close(itm->fd) || (itm->fd = open(new, O_CREAT | O_WRONLY, 0666)) < 1)
		ft_error("Can't creat file core");
	print_option(head, champ, *itm, new);
	close(itm->fd);
	free(new);
}

void	ft_asm(char **av)
{
	t_header	*head;
	t_inst		*champ;
	t_intmain	itm;

	head = NULL;
	init_header(&head);
	itm.i = 0;
	itm.opt = 0;
	while (++itm.i < 3)
	{
		itm.opt = !ft_strcmp(av[itm.i], "-a") ? 1 : itm.opt;
		if (ft_strcmp(av[itm.i], "-a"))
		{
			champ = NULL;
			if ((itm.fd = open(av[itm.i], O_RDONLY)) < 1)
				ft_error("Can't read source file core");
			get_line(itm.fd, &champ, head);
			open_it(&itm, av, champ, head);
			free_champ(&champ);
		}
	}
	free(head);
}
