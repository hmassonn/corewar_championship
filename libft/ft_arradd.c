/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_arradd.c                                        :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: hmassonn <hmassonn@student.42.fr>          +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2017/02/16 13:55:24 by hmassonn          #+#    #+#             */
/*   Updated: 2017/09/03 20:47:07 by hmassonn         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <stdlib.h>
#include "libft.h"

char		**ft_arradd(char **tab, char *str)
{
	int		len;
	int		i;
	char	**new;

	i = 0;
	len = ft_arrlen(tab);
	if (!(new = (char**)malloc(sizeof(char*) * (len + 2))))
		return (NULL);
	while (i < len)
	{
		if (!(new[i] = ft_strdup(tab[i])))
			return (NULL);
		i++;
	}
	if (!(new[i] = ft_strdup(str)))
		return (NULL);
	new[++i] = NULL;
	return (new);
}
