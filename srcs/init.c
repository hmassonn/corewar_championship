/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   init.c                                             :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: hmassonn <hmassonn@student.42.fr>          +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2017/10/20 13:43:50 by hmassonn          #+#    #+#             */
/*   Updated: 2017/10/23 08:31:15 by hmassonn         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "algen.h"

void	find_name(char (*name)[19])
{
	if ((*name)[13] >= '9')
	{
		(*name)[13] = '0';
		(*name)[12] += 1;
	}
	if ((*name)[12] >= '9')
	{
		(*name)[12] = '0';
		(*name)[11] += 1;
	}
	if ((*name)[11] >= '9')
	{
		(*name)[11] = '0';
		(*name)[10] += 1;
	}
	if ((*name)[10] >= '9')
		ft_error("find_name limite supérieur");
	if ((*name)[15] >= '9')
	{
		(*name)[15] = '0';
		if (((*name)[14] += 1) >= 'z')
			ft_error("POP_SIZE trop grande (max 240)");
	}
	else
		(*name)[15] += 1;
}

void	create_champ_header(int fd, char name[19])
{
	char	prename[7] = ".name \"";
	char	postname[25] = "\"\n.comment \"You loose\"\n\n";

	if (write(fd, prename, 7) < 1)
		ft_error("probleme de write sur le champion prename");
	if (write(fd, name, 18) < 1)
		ft_error("probleme de write sur le champion name");
	if (write(fd, postname, 24) < 1)
		ft_error("probleme de write sur le champion postname");
}
