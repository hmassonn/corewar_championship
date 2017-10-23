/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   main.c                                             :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: hmassonn <hmassonn@student.42.fr>          +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2017/10/20 13:43:50 by hmassonn          #+#    #+#             */
/*   Updated: 2017/10/23 08:37:18 by hmassonn         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "algen.h"

void	create_champ(int fd)
{
	char	zork[] = "l2:\tsti r1,%:live,%1\n\tand r1,%0,r1\n\nlive:\tlive %1\n\tzjmp %:live\n";

	if (write(fd, zork, 63) < 1)
		ft_error("probleme de write sur le champion body");
}

void	assemble(char name[19])
{
	char	**exe;

	if (!(exe = (char**)malloc(sizeof(char*) * 3)))
		ft_error("malloc");
	exe[0] = ft_strdup("ressources/asm");
	exe[1] = ft_strdup(name);
	exe[2] = NULL;
	ft_fork("ressources/asm", exe, NULL);
	ft_deltab(&exe);
}

void	init(char **av)
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
		assemble(name);
		x++;
	}
}

int		main(int ac, char **av)
{
	(void)ac;
	init(av);
	return (0);
}
