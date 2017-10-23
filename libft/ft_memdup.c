/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_memdup.c                                        :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: hmassonn <hmassonn@student.42.fr>          +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/12/10 16:11:51 by hmassonn          #+#    #+#             */
/*   Updated: 2016/12/10 17:11:02 by hmassonn         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"
#include "stdlib.h"

void	*ft_memdup(const void *s, size_t n)
{
	void	*new;

	if ((new = (void*)malloc(sizeof(unsigned char) * n)) == NULL)
		return (NULL);
	ft_memcpy(new, s, n);
	return (new);
}
