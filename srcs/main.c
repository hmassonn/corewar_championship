/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   main.c                                             :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: hmassonn <hmassonn@student.42.fr>          +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2017/10/20 13:43:50 by hmassonn          #+#    #+#             */
/*   Updated: 2017/10/23 15:56:57 by hmassonn         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "algen.h"
#include "op.h"
#include "corewar.h"

// void	old_fight(char **pool)
// {
// 	int		i = 0, j;
// 	char	**arg;
//
// 	if (!(arg = (char**)malloc(sizeof(char*) * 4)))
// 		my_error("malloc fight");
// 	arg[0] = ft_strdup("ressources/corewar");
// 	arg[3] = NULL;
// 	while (i < POP_SIZE)
// 	{
// 		arg[1] = ft_strjoin(pool[i], ".cor");
// 		j = i + 1;
// 		while (j < POP_SIZE)
// 		{
// 			arg[2] = ft_strjoin(pool[j], ".cor");
// 			my_fork(arg[0], arg, NULL);
// 			free(arg[2]);
// 			j++;
// 		}
// 		free(arg[1]);
// 		i++;
// 	}
// 	free(arg[0]);
// 	free(arg);
// }

void	fight(char **pool)
{
	int		i = 0, j;
	char	**arg;

	if (!(arg = (char**)malloc(sizeof(char*) * 4)))
		my_error("malloc fight");
	arg[0] = ft_strdup("-q");
	arg[3] = NULL;
	while (i < POP_SIZE)
	{
		arg[1] = ft_strjoin(pool[i], ".cor");
		j = i + 1;
		while (j < POP_SIZE)
		{
			arg[2] = ft_strjoin(pool[j], ".cor");
			ft_vm(arg);
			free(arg[2]);
			j++;
		}
		free(arg[1]);
		i++;
	}
	free(arg[0]);
	free(arg);
}

int		main(int ac, char **av)
{
	char	**pool;

	(void)ac;
	if (!(pool = (char**)malloc(sizeof(char*) * (POP_SIZE + 1))))
		my_error("malloc main");
	initial(av, &pool);
	// old_fight(pool);
	fight(pool);
	ft_deltab(&pool);
	return (0);
}
