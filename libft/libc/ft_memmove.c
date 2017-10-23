/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_memmove.c                                       :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: hmassonn <hmassonn@student.42.fr>          +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/11/03 18:50:54 by hmassonn          #+#    #+#             */
/*   Updated: 2017/09/16 21:57:31 by hmassonn         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

void	*ft_memmove(void *dst, const void *src, size_t len)
{
	t_unch	*d;
	t_unch	*s;
	size_t	i;

	d = (t_unch *)dst;
	s = (t_unch *)src;
	i = 0;
	if (s < d)
	{
		i++;
		while (i <= len)
		{
			d[len - i] = s[len - i];
			i++;
		}
	}
	else
	{
		while (i < len)
		{
			d[i] = s[i];
			i++;
		}
	}
	return (dst);
}
