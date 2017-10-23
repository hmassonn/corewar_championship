/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   get_next_line.c                                    :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: hmassonn <hmassonn@student.42.fr>          +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/11/16 15:04:15 by hmassonn          #+#    #+#             */
/*   Updated: 2017/09/16 22:16:14 by hmassonn         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <unistd.h>
#include <stdlib.h>
#include <fcntl.h>
#include "libft.h"

static char			*clean_back(char *str)
{
	int			i;

	i = -1;
	while (str[++i])
	{
		str[i] = (str[i] != '\n') ? str[i] : '\0';
		if (str[i] == '\0')
			return (str);
	}
	return (str);
}

static int			get_input(int fd, char **line)
{
	char		buff[BUFF_SIZE];
	int			stop;

	stop = 0;
	*line = (char *)ft_memalloc(sizeof(char));
	ft_bzero(buff, BUFF_SIZE);
	ft_bzero(*line, sizeof(char));
	while ((read(fd, buff, BUFF_SIZE - 1)) > 0)
	{
		if (ft_strchr(buff, '\n') || ft_strchr(buff, '\0'))
			stop = 1;
		if (!(*line))
			*line = clean_back(buff);
		else
			*line = ft_freejoin(*line, clean_back(buff));
		ft_bzero(buff, BUFF_SIZE);
		if (!(stop))
			*line = ft_realloc(*line, BUFF_SIZE - 1);
		else
			return (1);
	}
	return (0);
}

int					get_next_line(int fd, char **line)
{
	if (fd >= 0)
		return (get_input(fd, line));
	return (1);
}
