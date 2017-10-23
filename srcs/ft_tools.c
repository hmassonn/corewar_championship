/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_tools.c                                         :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: hmassonn <hmassonn@student.42.fr>          +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2017/10/20 13:43:50 by hmassonn          #+#    #+#             */
/*   Updated: 2017/10/23 14:24:58 by hmassonn         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "algen.h"
#include "op.h"

void 		my_error(char *str)
{
	ft_putendl(str);
	ft_putendl(strerror(errno));
	exit(-1);
}

char		*catch_signal(int signal)
{
	if (signal == 6)
		return ("ABRT");
	if (signal == 10)
		return ("BUSE");
	if (signal == 11)
		return ("SEGV");
	if (signal == 14)
		return ("TIMEOUT");
	return ("UNKNOWN_ERROR");
}

char		*ft_fork(char *cmd, char **args, char **ev)
{
	pid_t			father;

	if ((father = fork()) == -1)
		return ("FORK ERROR\n");
	if (father > 0)
	{
		wait(&father);
		if (WIFSIGNALED(father))
			return (catch_signal(WTERMSIG(father)));
		else if (father == 0)
			return ("");
	}
	if (father == 0)
		exit(execve(cmd, args, ev));
	return ("KO\n");
}
