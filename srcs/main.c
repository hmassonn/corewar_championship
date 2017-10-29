/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   main.c                                             :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: hmassonn <hmassonn@student.42.fr>          +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2017/10/20 13:43:50 by hmassonn          #+#    #+#             */
/*   Updated: 2017/10/23 21:08:34 by hmassonn         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "algen.h"
#include "op.h"
#include "corewar.h"

t_resu	g_champ;

void	cursor_plus() {
	g_champ.cursor++;
}

void	cursuor_mod(int who, int val) {
	g_champ.res[g_champ.cursor][who] = val+48;
}

void	bzero_champ() {
	int		i = 0;

	g_champ.cursor = 0;
	while (i < 5050)
	{
		g_champ.res[i][0] = 0;
		g_champ.res[i][1] = 0;
		g_champ.res[i][2] = 0;
		g_champ.res[i][3] = '\0';
		i++;
	}
}

void	fight(char **pool)
{
	int		i = 0, j;
	char	**arg;

	if (!(arg = (char**)malloc(sizeof(char*) * 5)))
		my_error("malloc fight");
	arg[0] = ft_strdup("-q");
	arg[1] = ft_strdup("-q");
	arg[4] = NULL;
	while (i < POP_SIZE)
	{
		arg[2] = ft_strjoin(pool[i], ".cor");
		j = i + 1;
		while (j < POP_SIZE)
		{
			arg[3] = ft_strjoin(pool[j], ".cor");
			g_champ.res[g_champ.cursor][0] = i+1;
			g_champ.res[g_champ.cursor][1] = j+1;
			ft_vm(arg);
			free(arg[3]);
			j++;
		}
		free(arg[2]);
		i++;
	}
	free(arg[0]);
	free(arg[1]);
	free(arg);
}

int		main(int ac, char **av)
{
	char	**pool;
	int		i = 0, fd;

	(void)ac;
	bzero_champ();
	if (!(pool = (char**)malloc(sizeof(char*) * (POP_SIZE + 1))))
		my_error("malloc main");
	while (i < POP_SIZE)
		pool[i++] = NULL;
	initial(av, &pool);
	fight(pool);
	i = 0;
	if ((fd = open("results", O_CREAT | O_WRONLY, 0777)) < 1)
		my_error("probleme sur le fichier results");
	while (i < 854)
	{
		ft_putnbr_fd(g_champ.res[i][0], fd);
		ft_putchar_fd(' ', fd);
		ft_putnbr_fd(g_champ.res[i][1], fd);
		ft_putchar_fd(' ', fd);
		ft_putchar_fd(g_champ.res[i++][2], fd);
		ft_putchar_fd('\n', fd);
	}
	close(fd);
	ft_deltab(&pool);
	return (0);
}
