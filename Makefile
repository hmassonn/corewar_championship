# **************************************************************************** #
#                                                                              #
#                                                         :::      ::::::::    #
#    Makefile                                           :+:      :+:    :+:    #
#                                                     +:+ +:+         +:+      #
#    By: hmassonn <hmassonn@student.42.fr>          +#+  +:+       +#+         #
#                                                 +#+#+#+#+#+   +#+            #
#    Created: 2016/11/02 18:56:27 by hmassonn          #+#    #+#              #
#    Updated: 2017/10/23 14:46:21 by hmassonn         ###   ########.fr        #
#                                                                              #
# **************************************************************************** #

NAME = algen

CC = gcc

CFLAGS = -Wall -Wextra -Werror

INC_PATH = ./includes/ ./libft/includes/
OBJ_PATH = obj/
LIB_PATH = libft/

SRC_PATH = srcs/
SRC_NAME =	main.c		\
			initial.c	\
			ft_tools.c

ASM_PATH = srcs_asm/
ASM_NAME =	asm.c			\
			op.c			\
			init.c			\
			take.c			\
			inst.c 			\
			debug.c 		\
			tools.c			\
			verif.c 		\
			calc.c 			\
			clean.c 		\
			fill_file.c 	\
			print.c			\
			verif_tools.c	\
			print_label.c	\
			get_line.c		\
			op_tools.c

VM_PATH = srcs_vm/
VM_NAME =	vm.c				\
			ft_addbuf.c			\
			ft_cpu_funcs.c		\
			ft_display_mars.c	\
			ft_draw_mars.c		\
			ft_dump.c			\
			ft_exit.c			\
			ft_fork.c			\
			ft_graph_funcs.c	\
			ft_ld.c				\
			ft_ldi.c			\
			ft_live.c			\
			ft_mars_funcs.c		\
			ft_math.c			\
			ft_ncurses_mars.c	\
			ft_op.c				\
			ft_print_mars.c		\
			ft_run_mars.c		\
			ft_skull_draw.c		\
			ft_skull_reset.c	\
			ft_st.c				\
			ft_sti.c			\
			ft_usage.c			\
			ft_music_load.c		\
			ft_zjmp.c			\
			ft_ncurses_init.c	\
			ft_aff.c

INC = $(addprefix -I, $(INC_PATH))

OBJ_ASM = $(addsuffix .o,			\
		  $(addprefix $(OBJ_PATH),	\
		  $(addprefix $(ASM_PATH),	\
		  $(basename $(ASM_NAME)))))

OBJ_VM = $(addsuffix .o,			\
		  $(addprefix $(OBJ_PATH),	\
		  $(addprefix $(VM_PATH),	\
		  $(basename $(VM_NAME)))))

OBJ_LO = $(addsuffix .o,			\
		  $(addprefix $(OBJ_PATH),	\
		  $(addprefix $(SRC_PATH),	\
		  $(basename $(SRC_NAME)))))

LIB_NAME = libft.a
LIB_FILE = $(addprefix $(LIB_PATH),$(LIB_NAME))

all: $(NAME)

$(NAME): $(OBJ_LO) $(OBJ_ASM) $(OBJ_VM)
	@echo "\033[34m[  LIBRAIRIES  ]\033[0m"
	@make -C $(LIB_PATH)
	mkdir champions
	chmod 777 champions
	@echo "\033[34m[ MAIN PROJECT ]\033[0m"
	@echo "\033[32m[$(NAME)]\t\t(release)\033[0m"
	$(CC) $(CFLAGS) -o $(NAME) $(INC) $^ $(LIB_FILE)

$(OBJ_PATH)$(SRC_PATH)%.o: $(SRC_PATH)%.c
	@mkdir -p $(OBJ_PATH)
	@mkdir -p $(OBJ_PATH)$(SRC_PATH)
	$(CC) -g $(CFLAGS) $(INC) -o $@ -c $<

$(OBJ_PATH)$(ASM_PATH)%.o: $(ASM_PATH)%.c
	@mkdir -p $(OBJ_PATH)
	@mkdir -p $(OBJ_PATH)$(ASM_PATH)
	$(CC) -g $(CFLAGS) $(INC) -o $@ -c $<

$(OBJ_PATH)$(VM_PATH)%.o: $(VM_PATH)%.c
	@mkdir -p $(OBJ_PATH)
	@mkdir -p $(OBJ_PATH)$(VM_PATH)
	$(CC) -g $(CFLAGS) $(INC) -o $@ -c $<

re: fclean all

clean:
	@rm -rf $(OBJ_PATH)
	@make -C $(LIB_PATH) clean

fclean: clean
	@rm -f $(NAME)
	@rm -rf .DS_Store
	@rm -rf ../.DS_Store
	@rm -f $(LIB_FILE)
	@echo "\n\033[31mWow ! I've clean $(NAME) so much !\033[0m\n"

.PHONY: re clean fclean all
