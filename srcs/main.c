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
	while (i <= 5050)
	{
		if (i <= POP_SIZE)
			g_champ.champ[i] = 0;
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
			g_champ.res[g_champ.cursor][0] = i;
			g_champ.res[g_champ.cursor][1] = j;
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
	int		i = 0, fd, len_path, pos;
	char	*first;

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
	len_path = strlen(PATH_CHAMPIONSHIP);
	// ft_arrprint(pool);
	while (i < 858)
	{
		if (g_champ.res[i][2] != '0')
		{
			pos = atoi(&g_champ.res[i][2]) - 1;
			g_champ.champ[(int)g_champ.res[i][pos]]++;
			// printf("i: %d pos: %d g_champ.res[i][pos]: %d\n", i, pos, (int)g_champ.res[i][pos]);
		}
		i++;
	}
	i = 0;
	while (i < POP_SIZE)
	{
		first = ft_strsub(pool[i], len_path, strlen(pool[i]) - len_path);
		ft_putstr_fd(first, fd);
		ft_putchar_fd(' ', fd);
		ft_putnbr_fd(g_champ.champ[i], fd);
		ft_putchar_fd('\n', fd);
		// ft_putstr_fd(first, 2);
		// ft_putchar_fd(' ', 2);
		// ft_putnbr_fd(g_champ.champ[i], 2);
		// ft_putchar_fd('\n', 2);
		i++;
	}
	// // ft_putnbr_fd((int)g_champ.res[i][0], 2);
	// // ft_putchar_fd(' ', 2);
	// // ft_putnbr_fd((int)g_champ.res[i][1], 2);
	// // ft_putchar_fd(' ', 2);
	// // ft_putstr_fd(pool[(int)g_champ.res[i][0]], 2);
	// // ft_putchar_fd(' ', 2);
	// // ft_putstr_fd(pool[(int)g_champ.res[i][1]], 2);
	// // ft_putchar_fd(' ', 2);
	// first = ft_strsub(pool[(int)g_champ.res[i][0]], len_path, strlen(pool[(int)g_champ.res[i][0]]) - len_path);
	// sec = ft_strsub(pool[(int)g_champ.res[i][1]], len_path, strlen(pool[(int)g_champ.res[i][1]]) - len_path);
	// // ft_putstr_fd(first, 2);
	// // ft_putchar_fd(' ', 2);
	// // ft_putstr_fd(sec, 2);
	// // ft_putchar_fd(' ', 2);
	// // ft_putchar_fd('\n', 2);
	// ft_putstr_fd(first, fd);
	// ft_putchar_fd(' ', fd);
	// ft_putstr_fd(sec, fd);
	// ft_putchar_fd(' ', fd);
	// ft_putchar_fd(g_champ.res[i++][2], fd);
	// ft_putchar_fd('\n', fd);
	close(fd);
	ft_deltab(&pool);
	return (0);
}
