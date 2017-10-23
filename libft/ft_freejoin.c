/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_freejoin.c                                      :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: hmassonn <hmassonn@student.42.fr>          +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/11/16 15:04:15 by hmassonn          #+#    #+#             */
/*   Updated: 2016/11/29 18:47:21 by hmassonn         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

char		*ft_freejoin(char *dst, char *src)
{
	char	*tmp;

	tmp = malloc(sizeof(char) * (ft_strlen(dst) + 1));
	tmp[0] = '\0';
	ft_strcpy(tmp, dst);
	ft_strdel(&dst);
	if ((dst = ft_strjoin(tmp, src)) == NULL)
		return (NULL);
	ft_strdel(&tmp);
	return (dst);
}
