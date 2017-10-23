/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   main.c                                             :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: hmassonn <hmassonn@student.42.fr>          +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2017/10/20 13:43:50 by hmassonn          #+#    #+#             */
/*   Updated: 2017/10/20 15:59:23 by hmassonn         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "algen.h"

void 	ft_error(char *str) {
	ft_putendl(str);
	exit(-1);
}

void	find_name(char (*new)[19])
{
	if ((*new)[13] >= '9')
	{
		(*new)[13] = '0';
		(*new)[12] += 1;
	}
	if ((*new)[12] >= '9')
	{
		(*new)[12] = '0';
		(*new)[11] += 1;
	}
	if ((*new)[11] >= '9')
	{
		(*new)[11] = '0';
		(*new)[10] += 1;
	}
	if ((*new)[10] >= '9')
		ft_error("find_name limite supérieur");
	if ((*new)[15] >= '9')
	{
		(*new)[15] = '0';
		if (((*new)[14] += 1) >= 'z')
			ft_error("POP_SIZE trop grande (max 240)");
	}
	else
		(*new)[15] += 1;
}

void	init(char **av)
{
	int		x = 0, fd;
	// int		size = 0;
	char	new[19] = "champions/0000a0.s";

	(void)av;
	while (x < POP_SIZE)
	{
		find_name(&new);
		fd = open(new, O_CREAT | O_RDWR, 0777);
		// create_champ(fd);
		close(fd);
		x++;
	}
}

int		main(int ac, char **av)
{
	(void)ac;
	init(av);
	return (0);
}
