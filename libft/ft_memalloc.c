/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_memalloc.c                                      :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: hmassonn <hmassonn@student.42.fr>          +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/11/05 18:02:36 by hmassonn          #+#    #+#             */
/*   Updated: 2016/11/29 18:44:25 by hmassonn         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <stdlib.h>
#include "libft.h"

void	*ft_memalloc(size_t size)
{
	void	*str;

	str = (char *)malloc(sizeof(char) * size);
	if (str == NULL)
		return (NULL);
	ft_memset(str, 0, size);
	return (str);
}
