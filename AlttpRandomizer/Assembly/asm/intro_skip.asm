.gba
;.Open "base/ALttP_US.gba","ALttP_US_MOD.gba",0 :: GlobalEqu VERSION "US"
;.Open "base/ALttP_JP.gba","ALttP_JP_MOD.gba",0 :: GlobalEqu VERSION "JP"
.if (VERSION == "US") 
	orga 0x12D77C
	strb r2, [r4, r1]
	strh r2, [r3]
	ldr r0, [0x12D7A4]
	ldrb r0, [r0]
	strb r3, [r0]
	cmp r0, #0
	beq 0x12D7AC

.elseif (VERSION == "JP")
	orga 0x12E770
	strb r2, [r4, r1]
	strh r2, [r3]
	ldr r0, [0x12E798]
	ldrb r0, [r0]
	strb r3, [r0]
	cmp r0, #0
	beq 0x12E7A0


.endif
