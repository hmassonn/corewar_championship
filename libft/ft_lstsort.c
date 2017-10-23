/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_lstsort.c                                       :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: hmassonn <hmassonn@student.42.fr>          +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/12/12 16:05:01 by hmassonn          #+#    #+#             */
/*   Updated: 2016/12/12 17:04:24 by hmassonn         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <libft.h>

void		ft_lstsort(t_list **origin)
{
	int		loop;
	t_list	*list;

	list = *origin;
	loop = 1;
	while (loop)
	{
		loop = 0;
		list = *origin;
		while (list && list->next != NULL)
		{
			if (ft_strcmp(list->content, list->next->content) > 0)
			{
				ft_lstswap(list, list->next);
				loop = 1;
			}
			list = list->next;
		}
	}
}
