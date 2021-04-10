.gba
; Uncomment the Version you need in case of non packaged use
;       Source File        Taget File                  Leave alone
;.Open "ALttP_US.gba",  "ALttP_US_MOD.gba",       0 :: VERSION equ "US"
;.Open "ALttP_JP.gba",  "ALttP_JP_MOD.gba",       0 :: VERSION equ "JP"
.if (VERSION == "US") 
	orga 0x12D77C
	strb r2, [r4, r1]		; this was done in 2 instructions, first putting r4+r1 into r0, then storing r2 to where r0 points to, thanks Nintendo :)
	strh r2, [r3]			;
	ldr r0, [0x12D7A4]		; Pretty much the next few lines are just moving the prior statements 1 instruction back.
	ldrb r2, [r0]			; Changing the data register to r2 though so we keep the Address Register.
	cmp r2, #0				; Comparing 0 to our changed data register
	strb r3, [r0]			; Now we store r3 (just a register with a non 0 address) where r0 points to, this prevents future NG+ Text Boxes. Doesn't just overwrite flags on ARM.
	beq 0x12D7AC			; Was a bne before. We now just branch the first time (the only time r0 resolves to a 0) and all other times we check weather i think 0xDC0 equals #0.

.elseif (VERSION == "JP")
	orga 0x12E770
	strb r2, [r4, r1]		; JP is the same as US, just with different Addresses
	strh r2, [r3]			;
	ldr r0, [0x12E798]		;
	ldrb r2, [r0]			;
	cmp r2, #0				;
	strb r3, [r0]			;
	beq 0x12E7A0


.endif
