/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   initial.c                                          :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: hmassonn <hmassonn@student.42.fr>          +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2017/10/20 13:43:50 by hmassonn          #+#    #+#             */
/*   Updated: 2017/10/23 21:08:44 by hmassonn         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "algen.h"
#include "op.h"

int		find_name(char **name, DIR **ptdir)
{
	struct dirent	*entree;
	static int		init = 0;

	if (init == 0)
		*ptdir = opendir(PATH_CHAMPIONSHIP);
	if (*name != NULL)
	{
		free(*name);
		*name = NULL;
	}
	if (init == 0 && !*ptdir)
	{
		fprintf(stderr, "Pb opendir \n");
		// perror(opendir);
		exit(1);
	}
	if (init == 0)
		init++;
	entree = readdir(*ptdir);
	if (!entree)
		return 0;
	while (!strcmp(entree->d_name, ".") || !strcmp(entree->d_name, ".."))
		entree = readdir(*ptdir);
	if (entree != NULL)
		*name = ft_strdup(entree->d_name);
	return 1;
}

void	initial(char **av, char ***pool)
{
	int		x = 0;
	DIR		*ptdir = NULL;
	// int		fd;
	// char	name[19] = "champions/0000a0.s";
	char	*name = NULL, *full_name = NULL;

	(void)av;
	while (x < POP_SIZE)
	{
		// old_find_name(&name);
		// fd = open(name, O_CREAT | O_RDWR, 0777);
		// create_champ_header(fd, name);
		// create_champ(fd);
		// close(fd);
		if (find_name(&name, &ptdir) == 1)
		{
			full_name = ft_strjoin(PATH_CHAMPIONSHIP, name);
			ft_strdel(&name);
			ft_asm(full_name);
			name = ft_strsub(full_name, 0, strlen(full_name) - 2);
			(*pool)[x] = ft_strdup(name);
			ft_strdel(&name);
		}
		else
		{
			closedir(ptdir);
			(*pool)[x] = NULL;
			return ;
		}
		x++;
	}
}


// void	old_find_name(char (*name)[19])
// {
// 	if ((*name)[13] >= '9')
// 	{
// 		(*name)[13] = '0';
// 		(*name)[12] += 1;
// 	}
// 	if ((*name)[12] >= '9')
// 	{
// 		(*name)[12] = '0';
// 		(*name)[11] += 1;
// 	}
// 	if ((*name)[11] >= '9')
// 	{
// 		(*name)[11] = '0';
// 		(*name)[10] += 1;
// 	}
// 	if ((*name)[10] >= '9')
// 		my_error("find_name limite supérieur");
// 	if ((*name)[15] >= '9')
// 	{
// 		(*name)[15] = '0';
// 		if (((*name)[14] += 1) >= 'z')
// 			my_error("POP_SIZE trop grande (max 240)");
// 	}
// 	else
// 		(*name)[15] += 1;
// }

// void	create_champ_header(int fd, char name[19])
// {
// 	char	prename[7] = ".name \"";
// 	char	postname[25] = "\"\n.comment \"You loose\"\n\n";
//
// 	if (write(fd, prename, 7) < 1)
// 		my_error("probleme de write sur le champion prename");
// 	if (write(fd, name, 18) < 1)
// 		my_error("probleme de write sur le champion name");
// 	if (write(fd, postname, 24) < 1)
// 		my_error("probleme de write sur le champion postname");
// }

// void	create_champ(int fd)
// {
// 	char	zork[] = "l2:\tsti r1,%:live,%1\n\tand r1,%0,r1\n\nlive:\tlive %1\n\tzjmp %:live\n";
//
// 	if (write(fd, zork, 63) < 1)
// 		my_error("probleme de write sur le champion body");
// }
