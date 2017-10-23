/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_arrdel.c                                        :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: rbadia <rbadia@student.42.fr>              +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/11/15 18:27:43 by rbadia            #+#    #+#             */
/*   Updated: 2017/09/03 22:35:29 by hmassonn         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <stdlib.h>
#include "libft.h"

void	ft_arrdel(char **array)
{
	int	y;

	y = 0;
	if (array)
	{
		while (array[y])
		{
			free(array[y]);
			y++;
		}
		free(array);
		array = NULL;
	}
}
