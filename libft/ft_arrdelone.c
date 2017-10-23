/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_arrdelone.c                                     :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: hmassonn <hmassonn@student.42.fr>          +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/11/14 14:28:19 by hmassonn          #+#    #+#             */
/*   Updated: 2017/09/03 20:47:31 by hmassonn         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <stdlib.h>
#include "libft.h"

char		**ft_arrdelone(char **tab, int pos)
{
	int		i;

	i = 0;
	if (pos < 0)
		return (NULL);
	while (tab[i] && i < pos)
		i++;
	if (i != pos)
		return (NULL);
	free(tab[i]);
	while (tab[i + 1])
	{
		tab[i] = tab[i + 1];
		i++;
	}
	tab[i] = NULL;
	return (tab);
}
