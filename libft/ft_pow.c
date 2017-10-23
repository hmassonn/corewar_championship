/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_pow.c                                           :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: clanier <clanier@student.42.fr>            +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/11/07 05:05:55 by clanier           #+#    #+#             */
/*   Updated: 2017/10/23 15:13:14 by hmassonn         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

double	ft_pow(double n, int exp)
{
	if (exp == 0)
		return (1);
	else if (exp > 0)
		return (n * ft_pow(n, exp - 1));
	else
		return (1 / n * ft_pow(1 / n, -exp - 1));
}
