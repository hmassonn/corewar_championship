/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_arrdup.c                                        :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: hmassonn <hmassonn@student.42.fr>          +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/11/14 14:28:19 by hmassonn          #+#    #+#             */
/*   Updated: 2017/09/06 16:36:26 by hmassonn         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <stdlib.h>
#include "libft.h"

char	**ft_arrdup(char **tab)
{
	char	**array;
	int		i;

	i = 0;
	while (tab[i])
		i++;
	if (!(array = (char **)malloc(sizeof(char *) * (i + 1))))
		return (NULL);
	i = 0;
	while (tab[i])
	{
		array[i] = ft_strdup(tab[i]);
		i++;
	}
	array[i] = NULL;
	return (array);
}
