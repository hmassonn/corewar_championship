/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_lstswap.c                                       :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: hmassonn <hmassonn@student.42.fr>          +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/12/12 16:23:02 by hmassonn          #+#    #+#             */
/*   Updated: 2016/12/12 18:57:15 by hmassonn         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <libft.h>
#include <stdlib.h>

void		ft_lstswap(t_list *s1, t_list *s2)
{
	t_list	tmp;
	size_t	size;

	size = sizeof(t_list) - sizeof(t_list*);
	ft_memmove(&tmp, s1, size);
	ft_memmove(s1, s2, size);
	ft_memmove(s2, &tmp, size);
}
