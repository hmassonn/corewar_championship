/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   initial.c                                          :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: hmassonn <hmassonn@student.42.fr>          +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2017/10/20 13:43:50 by hmassonn          #+#    #+#             */
/*   Updated: 2017/10/23 15:54:27 by hmassonn         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "algen.h"
#include "op.h"

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
		my_error("find_name limite supérieur");
	if ((*name)[15] >= '9')
	{
		(*name)[15] = '0';
		if (((*name)[14] += 1) >= 'z')
			my_error("POP_SIZE trop grande (max 240)");
	}
	else
		(*name)[15] += 1;
}

void	create_champ_header(int fd, char name[19])
{
	char	prename[7] = ".name \"";
	char	postname[25] = "\"\n.comment \"You loose\"\n\n";

	if (write(fd, prename, 7) < 1)
		my_error("probleme de write sur le champion prename");
	if (write(fd, name, 18) < 1)
		my_error("probleme de write sur le champion name");
	if (write(fd, postname, 24) < 1)
		my_error("probleme de write sur le champion postname");
}

void	create_champ(int fd)
{
	char	zork[] = "l2:\tsti r1,%:live,%1\n\tand r1,%0,r1\n\nlive:\tlive %1\n\tzjmp %:live\n";

	if (write(fd, zork, 63) < 1)
		my_error("probleme de write sur le champion body");
}

// void	assemble(char name[19])
// {
// 	char	**exe;
//
// 	if (!(exe = (char**)malloc(sizeof(char*) * 3)))
// 		my_error("malloc assemble");
// 	exe[0] = ft_strdup("ressources/asm");
// 	exe[1] = ft_strdup(name);
// 	exe[2] = NULL;
// 	my_fork("ressources/asm", exe, NULL);
// 	ft_deltab(&exe);
// }

void	initial(char **av, char ***pool)
{
	int		x = 0, fd;
	char	name[19] = "champions/0000a0.s";

	(void)av;
	while (x < POP_SIZE)
	{
		find_name(&name);
		fd = open(name, O_CREAT | O_RDWR, 0777);
		create_champ_header(fd, name);
		create_champ(fd);
		close(fd);
		// assemble(name);
		ft_asm(name);
		(*pool)[x] = ft_strndup(name, 16);
		x++;
	}
	(*pool)[x] = NULL;
}
