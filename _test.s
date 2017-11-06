.name "_test"
.comment "on en a gros"
start:
    ld  %507, r4
    ld  %507, r6
    ld  %17, r8
    ld  %190055170, r9
    ld  %67699190, r10
    st  r9, 511
    st  r10, 510
    fork %:proc2
proc1:
    live %65535
    ld  %0, r2
    ld %190055682, r3
    ld %190056194, r5
    ld %190056194, r7
    ld  %0, r16
    zjmp %458
proc2:
    ld  %4, r2
    live %65535
    ld %67699190, r3
    ld %101253622, r5
    ld %134807564, r7
    ld  %0, r16
    zjmp %415
