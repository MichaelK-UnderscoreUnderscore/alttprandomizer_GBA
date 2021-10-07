.gba
; Uncomment the Version you need in case of non packaged use
;       Source File        Taget File                  Leave alone
;.Open "ALttP_US.gba",  "ALttP_US_MOD.gba",       0 :: VERSION equ "US"
;.Open "ALttP_JP.gba",  "ALttP_JP_MOD.gba",       0 :: VERSION equ "JP"
;.if (VERSION == "US") 
	orga 0x111B08
	bne 0x111B30
	orga 0x111B16
	bne 0x111B30

;.elseif (VERSION == "JP")
;	orga 0x12E770
;	strb r2, [r4, r1]		; JP is the same as US, just with different Addresses
;	strh r2, [r3]			;
;	ldr r0, [0x12E798]		;
;	ldrb r2, [r0]			;
;	cmp r2, #0				;
;	strb r3, [r0]			;
;	beq 0x12E7A0
;
;
;.endif