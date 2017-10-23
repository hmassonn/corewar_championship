/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   get_next_line.c                                    :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: hmassonn <hmassonn@student.42.fr>          +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/11/16 15:04:15 by hmassonn          #+#    #+#             */
/*   Updated: 2017/10/23 20:43:17 by hmassonn         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <unistd.h>
#include <stdlib.h>
#include <fcntl.h>
#include "libft.h"

int		get_next_line(const int fd, char **line)
{
	char		buf[BUFF_SIZE + 1];
	static char	*remains[42000];
	char		*tmp;
	int			ret;

	if ((ret = 1) && (fd < 0 || !line || BUFF_SIZE < 1))
		return (-1);
	ft_bzero(buf, BUFF_SIZE + 1);
	if (!(tmp = NULL) && remains[fd] && remains[fd][0])
		tmp = ft_strdup(remains[fd]);
	while (!ft_strchr(tmp, '\n') && (ret = read(fd, &buf, BUFF_SIZE)) != 0)
		if (ret < 0 || (!(buf[ret] = 0)
		&& !(tmp = ft_freejoin(tmp, buf))))
			return (-1);
	if (remains[fd])
		free(remains[fd]);
	if (ret == 0 && !tmp && !(remains[fd] = NULL))
		return (0);
	remains[fd] = ft_strchr(tmp, '\n') ?
	ft_strdup(ft_strchr(tmp, '\n') + 1) : NULL;
	*line = ft_strcdup(tmp, '\n');
	free(tmp);
	return (1);
}
