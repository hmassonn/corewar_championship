/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   algen.h                                            :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: hmassonn <hmassonn@student.42.fr>          +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2017/10/20 13:43:50 by hmassonn          #+#    #+#             */
/*   Updated: 2017/10/23 08:32:51 by hmassonn         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#ifndef OP_H
# define OP_H

#include <unistd.h>
#include <fcntl.h>
#include <errno.h>
# include "libft.h"

#define POP_SIZE	100
#define N_KIN		10
#define N_CHILD		10
#define N_TARGET	1

/*
**		dans init.c
*/

void	find_name(char (*name)[19]);
void	create_champ_header(int fd, char name[19]);

/*
**		dans init.c
*/

void 	ft_error(char *str);
char	*catch_signal(int signal);
char	*ft_fork(char *cmd, char **args, char **ev);

#endif
