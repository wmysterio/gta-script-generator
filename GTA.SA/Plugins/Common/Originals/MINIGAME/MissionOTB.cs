using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalMinigame {

        private sealed class OTB : MissionCustom {

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @OTB_16 
gosub @OTB_13293 
end_thread 

:OTB_16
" + OnMission + @" = 1 
wait 0 
054C: use_GXT_table 'OTB' 
03F0: enable_text_draw 1 
0390: load_txd_dictionary 'LD_OTB2' 
03CF: load_wav 1821 as 4 
038F: load_texture ""BUTNA"" as 1 
038F: load_texture ""BUTNB"" as 2 
038F: load_texture ""BUTNC"" as 3 
038F: load_texture ""RIC1"" as 4 
038F: load_texture ""RIC2"" as 5 
038F: load_texture ""RIC3"" as 6 
038F: load_texture ""RIC4"" as 7 
038F: load_texture ""RIC5"" as 8 
038F: load_texture ""BACKBET"" as 9 
038F: load_texture ""BUTNAO"" as 10 
038F: load_texture ""BUTNBO"" as 11 
34@ = 58.8281 
35@ = 225.0068 
36@ = 131.5202 
0087: 37@ = 36@ 
005B: 37@ += 34@ 
0087: 38@ = 37@ 
005B: 38@ += 34@ 
0087: 39@ = 38@ 
005B: 39@ += 34@ 
0087: 40@ = 39@ 
005B: 40@ += 34@ 
45@ = 93.8682 
46@ = 42.34 
47@ = 463.313 
55@ = 191.6589 
0087: 48@ = 47@ 
005B: 48@ += 45@ 
0087: 56@ = 55@ 
0087: 49@ = 47@ 
0087: 57@ = 55@ 
005B: 57@ += 46@ 
0087: 50@ = 47@ 
005B: 50@ += 45@ 
0087: 58@ = 55@ 
005B: 58@ += 46@ 
0087: 51@ = 49@ 
0087: 59@ = 57@ 
005B: 59@ += 46@ 
0087: 52@ = 51@ 
005B: 52@ += 45@ 
0087: 60@ = 59@ 
0087: 53@ = 51@ 
0087: 61@ = 59@ 
005B: 61@ += 46@ 
0087: 54@ = 51@ 
005B: 54@ += 45@ 
0087: 62@ = 59@ 
005B: 62@ += 46@ 
63@ = 510.0702 
64@ = 385.0263 
65@ = 1 
66@ = 0 
67@ = 0 
68@ = 0 
69@ = 0 
70@ = 1 
71@ = 1 
72@ = 1 
73@ = 1 
74@ = 1 
75@ = 1 
76@ = 0 
77@ = 0 
78@ = 0 
79@ = 0 
80@ = 0 
81@ = 0 
82@ = 0 
83@ = 0 
84@ = 0 
85@ = 0 
86@ = 0 
87@ = 0 
88@ = 0 
89@ = 5 
90@ = 25 
91@ = 100 
92@ = 250 
93@ = 1000 
94@ = 5000 
95@ = 10000 
05AA: 97@s = 'HORS__1' 
05AA: 99@s = 'HORS__2' 
05AA: 101@s = 'HORS__3' 
05AA: 103@s = 'HORS__4' 
05AA: 105@s = 'HORS__5' 
05AA: 107@s = 'HORS__6' 
05AA: 109@s = 'HORS__7' 
05AA: 111@s = 'HORS__8' 
05AA: 113@s = 'HORS__9' 
05AA: 115@s = 'HORS_10' 
05AA: 117@s = 'HORS_11' 
05AA: 119@s = 'HORS_12' 
05AA: 121@s = 'HORS_13' 
05AA: 123@s = 'HORS_14' 
05AA: 125@s = 'HORS_15' 
05AA: 127@s = 'HORS_16' 
05AA: 129@s = 'HORS_17' 
05AA: 131@s = 'HORS_18' 
05AA: 133@s = 'HORS_19' 
05AA: 135@s = 'HORS_20' 
05AA: 137@s = 'HORS_21' 
05AA: 139@s = 'HORS_22' 
05AA: 141@s = 'HORS_23' 
05AA: 143@s = 'HORS_24' 
05AA: 145@s = 'HORS_25' 
05AA: 147@s = 'HORS_26' 
05AA: 149@s = 'HORS_27' 
05AA: 151@s = 'HORS_28' 
05AA: 153@s = 'HORS_29' 
05AA: 155@s = 'HORS_30' 
05AA: 157@s = 'HORS_31' 
05AA: 159@s = 'HORS_32' 
05AA: 161@s = 'HORS_33' 
05AA: 163@s = 'HORS_34' 
05AA: 165@s = 'HORS_35' 
05AA: 167@s = 'HORS_36' 
05AA: 169@s = 'HORS_37' 
05AA: 171@s = 'HORS_38' 
05AA: 173@s = 'HORS_39' 
05AA: 175@s = 'HORS_40' 
05AA: 177@s = 'HORS_41' 
05AA: 179@s = 'HORS_42' 
05AA: 181@s = 'HORS_43' 
05AA: 183@s = 'HORS_44' 
05AA: 185@s = 'HORS_45' 
05AA: 187@s = 'HORS_46' 
05AA: 189@s = 'HORS_47' 
05AA: 191@s = 'HORS_48' 
05AA: 193@s = 'HORS_49' 
05AA: 195@s = 'HORS_50' 
05AA: 197@s = 'HORS_51' 
05AA: 199@s = 'HORS_52' 
05AA: 201@s = 'HORS_53' 
05AA: 203@s = 'HORS_54' 
05AA: 205@s = 'HORS_55' 
05AA: 207@s = 'HORS_56' 
05AA: 209@s = 'HORS_57' 
05AA: 211@s = 'HORS_58' 
05AA: 213@s = 'HORS_59' 
05AA: 215@s = 'HORS_60' 
05AA: 217@s = 'HORS_61' 
05AA: 219@s = 'HORS_62' 
05AA: 221@s = 'HORS_63' 
05AA: 223@s = 'HORS_64' 
05AA: 225@s = 'HORS_65' 
05AA: 227@s = 'HORS_66' 
05AA: 229@s = 'HORS_67' 
05AA: 231@s = 'HORS_68' 
05AA: 233@s = 'HORS_69' 
05AA: 235@s = 'HORS_70' 
05AA: 237@s = 'HORS_71' 
05AA: 239@s = 'HORS_72' 
05AA: 241@s = 'HORS_73' 
05AA: 243@s = 'HORS_74' 
05AA: 245@s = 'HORS_75' 
05AA: 247@s = 'HORS_76' 
05AA: 249@s = 'HORS_77' 
05AA: 251@s = 'HORS_78' 
05AA: 253@s = 'HORS_79' 
05AA: 255@s = 'HORS_80' 
05AA: 257@s = 'HORS_81' 
05AA: 259@s = 'HORS_82' 
05AA: 261@s = 'HORS_83' 
05AA: 263@s = 'HORS_84' 
05AA: 265@s = 'HORS_85' 
05AA: 267@s = 'HORS_86' 
05AA: 269@s = 'HORS_87' 
05AA: 271@s = 'HORS_88' 
05AA: 273@s = 'HORS_89' 
05AA: 275@s = 'HORS_90' 
05AA: 277@s = 'HORS_91' 
05AA: 279@s = 'HORS_92' 
05AA: 281@s = 'HORS_93' 
05AA: 283@s = 'HORS_94' 
05AA: 285@s = 'HORS_95' 
05AA: 287@s = 'HORS_96' 
05AA: 289@s = 'HORS_97' 
05AA: 291@s = 'HORS_98' 
05AA: 293@s = 'HORS_99' 
05AA: 295@s = 'HORS100' 
05AA: 297@s = 'HORS101' 
05AA: 299@s = 'HORS102' 
05AA: 301@s = 'HORS103' 
05AA: 303@s = 'HORS104' 
05AA: 305@s = 'HORS105' 
05AA: 307@s = 'HORS106' 
05AA: 309@s = 'HORS107' 
05AA: 311@s = 'HORS108' 
05AA: 313@s = 'HORS109' 
05AA: 315@s = 'HORS110' 
05AA: 317@s = 'HORS111' 
05AA: 319@s = 'HORS112' 
05AA: 321@s = 'HORS113' 
05AA: 323@s = 'HORS114' 
05AA: 325@s = 'HORS115' 
05AA: 327@s = 'HORS116' 
05AA: 329@s = 'HORS117' 
05AA: 331@s = 'HORS118' 
05AA: 333@s = 'HORS119' 
05AA: 335@s = 'HORS120' 
05AA: 337@s = 'HORS121' 
05AA: 339@s = 'HORS122' 
05AA: 341@s = 'HORS123' 
05AA: 343@s = 'HORS124' 
05AA: 345@s = 'HORS125' 
05AA: 347@s = 'HORS126' 
05AA: 349@s = 'HORS127' 
05AA: 351@s = 'HORS128' 
05AA: 353@s = 'HORS129' 
05AA: 355@s = 'HORS130' 
05AA: 357@s = 'HORS131' 
05AA: 359@s = 'HORS132' 
05AA: 361@s = 'HORS133' 
05AA: 363@s = 'HORS134' 
05AA: 365@s = 'HORS135' 
05AA: 367@s = 'HORS136' 
05AA: 369@s = 'HORS137' 
05AA: 371@s = 'HORS138' 
05AA: 373@s = 'HORS139' 
05AA: 375@s = 'HORS140' 
05AA: 377@s = 'HORS141' 
05AA: 379@s = 'HORS142' 
05AA: 381@s = 'HORS143' 
05AA: 383@s = 'HORS144' 
05AA: 385@s = 'HORS145' 
05AA: 387@s = 'HORS146' 
05AA: 389@s = 'HORS147' 
05AA: 391@s = 'HORS148' 
05AA: 393@s = 'HORS149' 
05AA: 395@s = 'HORS150' 
05AA: 397@s = 'HORS151' 
05AA: 399@s = 'HORS152' 
05AA: 401@s = 'HORS153' 
05AA: 403@s = 'HORS154' 
05AA: 405@s = 'HORS155' 
05AA: 407@s = 'HORS156' 
05AA: 409@s = 'HORS157' 
05AA: 411@s = 'HORS158' 
05AA: 413@s = 'HORS159' 
05AA: 415@s = 'HORS160' 
05AA: 417@s = 'HORS161' 
05AA: 419@s = 'HORS162' 
05AA: 421@s = 'HORS163' 
05AA: 423@s = 'HORS164' 
05AA: 425@s = 'HORS165' 
05AA: 427@s = 'HORS166' 
05AA: 429@s = 'HORS167' 
431@ = -1 
432@ = -1 
433@ = -1 
434@ = -1 
435@ = -1 
0209: 431@ = random_int_in_ranges 0 167 

:OTB_3133
if or
003B:   431@ == 432@ 
  432@ == -1 
else_jump @OTB_3176 
0209: 432@ = random_int_in_ranges 0 167 
jump @OTB_3133 

:OTB_3176
if or
003B:   431@ == 433@ 
003B:   432@ == 433@ 
  433@ == -1 
else_jump @OTB_3227 
0209: 433@ = random_int_in_ranges 0 167 
jump @OTB_3176 

:OTB_3227
if or
003B:   431@ == 434@ 
003B:   432@ == 434@ 
003B:   433@ == 434@ 
  434@ == -1 
else_jump @OTB_3286 
0209: 434@ = random_int_in_ranges 0 167 
jump @OTB_3227 

:OTB_3286
if or
003B:   431@ == 435@ 
003B:   432@ == 435@ 
003B:   433@ == 435@ 
003B:   434@ == 435@ 
  435@ == -1 
else_jump @OTB_3353 
0209: 435@ = random_int_in_ranges 0 167 
jump @OTB_3286 

:OTB_3353
438@ = 1 
439@ = 1 
440@ = 1 
441@ = 1 
442@ = 1 
436@ = 0 

:OTB_3395
if 
  5 > 436@ 
else_jump @OTB_3504 
437@ = 0 

:OTB_3420
if 
  5 > 437@ 
else_jump @OTB_3490 
if 
001D:   431@(437@,5i) > 431@(436@,5i) 
else_jump @OTB_3476 
438@(436@,5i) += 1 

:OTB_3476
437@ += 1 
jump @OTB_3420 

:OTB_3490
436@ += 1 
jump @OTB_3395 

:OTB_3504
436@ = 0 

:OTB_3511
if 
  5 > 436@ 
else_jump @OTB_3713 
if 
  438@(436@,5i) == 1 
else_jump @OTB_3563 
0085: 443@ = 431@(436@,5i) 

:OTB_3563
if 
  438@(436@,5i) == 2 
else_jump @OTB_3597 
0085: 444@ = 431@(436@,5i) 

:OTB_3597
if 
  438@(436@,5i) == 3 
else_jump @OTB_3631 
0085: 445@ = 431@(436@,5i) 

:OTB_3631
if 
  438@(436@,5i) == 4 
else_jump @OTB_3665 
0085: 446@ = 431@(436@,5i) 

:OTB_3665
if 
  438@(436@,5i) == 5 
else_jump @OTB_3699 
0085: 447@ = 431@(436@,5i) 

:OTB_3699
436@ += 1 
jump @OTB_3511 

:OTB_3713
0209: 448@ = random_int_in_ranges 2 4 
0209: 449@ = random_int_in_ranges 4 6 
0209: 450@ = random_int_in_ranges 6 9 
0209: 451@ = random_int_in_ranges 9 11 
0209: 452@ = random_int_in_ranges 11 13 
453@ = 0 

:OTB_3765
if 
83D0:   not wav 4 loaded 
else_jump @OTB_3791 
wait 0 
jump @OTB_3765 

:OTB_3791
fade 1 0 
038E: draw_box_position 320.0 224.0 size 640.0 448.0 RGBA 0 0 0 255 

:OTB_3828
wait 0 
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
038D: draw_texture 9 position 320.0 224.0 size 640.0 448.0 RGBA 150 150 150 255 
gosub @OTB_13568 
033F: set_text_draw_letter_size 0.759 2.8293 
0342: set_text_draw_centered 1 
033E: set_draw_text_position 204.407 39.1245 GXT 'HRACE01'  
454@ = 60.1776 
gosub @OTB_13568 
033F: set_text_draw_letter_size 0.527 2.0 
09FD: get_gxt_string 'XSELECT' width_to 455@  
033E: set_draw_text_position 454@ 395.7635 GXT 'XSELECT'  
0093: 467@ = integer 455@ to_float 
005B: 454@ += 467@ 
454@ += 8.0 
gosub @OTB_13568 
033F: set_text_draw_letter_size 0.527 2.0 
if 
  76@ == 0 
else_jump @OTB_4082 
09FD: get_gxt_string 'TRIEXIT' width_to 455@  
033E: set_draw_text_position 454@ 395.7635 GXT 'TRIEXIT'  
jump @OTB_4115 

:OTB_4082
09FD: get_gxt_string 'TRIBACK' width_to 455@  
033E: set_draw_text_position 454@ 395.7635 GXT 'TRIBACK'  

:OTB_4115
0093: 467@ = integer 455@ to_float 
005B: 454@ += 467@ 
454@ += 8.0 
gosub @OTB_13568 
033F: set_text_draw_letter_size 0.527 2.0 
if 
  76@ == 0 
else_jump @OTB_4204 
033E: set_draw_text_position 454@ 395.7635 GXT 'DPADNUD'  
jump @OTB_4223 

:OTB_4204
033E: set_draw_text_position 454@ 395.7635 GXT 'DPADNAV'  

:OTB_4223
96@ = Player.Money(" + PlayerChar + @")
gosub @OTB_13568 
033F: set_text_draw_letter_size 0.4753 2.2289 
0342: set_text_draw_centered 1 
045A: draw_text_1number 508.6669 18.0933 GXT 'YOURCSH' number 96@  
0494: get_joystick 0 direction_offset_to 456@ 457@ 458@ 459@ 
if 
  76@ == 0 
else_jump @OTB_5082 
if or
  -100 > 457@ 
00E1:   player 0 pressed_key 8 
else_jump @OTB_4496 
if 
  70@ == 0 
else_jump @OTB_4489 
if 
  66@ == 1 
else_jump @OTB_4386 
66@ = 0 
65@ = 1 

:OTB_4386
if 
  67@ == 1 
else_jump @OTB_4418 
67@ = 0 
66@ = 1 

:OTB_4418
if 
  68@ == 1 
else_jump @OTB_4450 
68@ = 0 
67@ = 1 

:OTB_4450
if 
  69@ == 1 
else_jump @OTB_4482 
69@ = 0 
68@ = 1 

:OTB_4482
70@ = 1 

:OTB_4489
jump @OTB_4503 

:OTB_4496
70@ = 0 

:OTB_4503
if or
  457@ > 100 
00E1:   player 0 pressed_key 9 
else_jump @OTB_4687 
if 
  71@ == 0 
else_jump @OTB_4680 
if 
  68@ == 1 
else_jump @OTB_4577 
68@ = 0 
69@ = 1 

:OTB_4577
if 
  67@ == 1 
else_jump @OTB_4609 
67@ = 0 
68@ = 1 

:OTB_4609
if 
  66@ == 1 
else_jump @OTB_4641 
66@ = 0 
67@ = 1 

:OTB_4641
if 
  65@ == 1 
else_jump @OTB_4673 
65@ = 0 
66@ = 1 

:OTB_4673
71@ = 1 

:OTB_4680
jump @OTB_4694 

:OTB_4687
71@ = 0 

:OTB_4694
if 
00E1:   player 0 pressed_key 16 
else_jump @OTB_5007 
if 
  74@ == 0 
else_jump @OTB_5000 
if 
  65@ == 1 
else_jump @OTB_4775 
66@ = 2 
67@ = 2 
68@ = 2 
69@ = 2 

:OTB_4775
if 
  66@ == 1 
else_jump @OTB_4821 
65@ = 2 
67@ = 2 
68@ = 2 
69@ = 2 

:OTB_4821
if 
  67@ == 1 
else_jump @OTB_4867 
65@ = 2 
66@ = 2 
68@ = 2 
69@ = 2 

:OTB_4867
if 
  68@ == 1 
else_jump @OTB_4913 
65@ = 2 
66@ = 2 
67@ = 2 
69@ = 2 

:OTB_4913
if 
  69@ == 1 
else_jump @OTB_4959 
65@ = 2 
66@ = 2 
67@ = 2 
68@ = 2 

:OTB_4959
74@ = 1 
78@ = 1 
76@ += 1 
018C: play_sound 1052 at 0.0 0.0 0.0 

:OTB_5000
jump @OTB_5014 

:OTB_5007
74@ = 0 

:OTB_5014
if 
00E1:   player 0 pressed_key 15 
else_jump @OTB_5075 
if 
  75@ == 0 
else_jump @OTB_5068 
75@ = 1 
fade 0 0 
wait 0 
return 

:OTB_5068
jump @OTB_5082 

:OTB_5075
75@ = 0 

:OTB_5082
460@ = 0 

:OTB_5089
if 
  5 > 460@ 
else_jump @OTB_5627 
if 
  65@(460@,5i) == 0 
else_jump @OTB_5165 
038D: draw_texture 1 position 35@ 36@(460@,5f) size 330.0 64.0 RGBA 150 150 150 255 

:OTB_5165
if 
  65@(460@,5i) == 1 
else_jump @OTB_5223 
038D: draw_texture 10 position 35@ 36@(460@,5f) size 330.0 64.0 RGBA 150 150 150 255 

:OTB_5223
if 
  65@(460@,5i) == 2 
else_jump @OTB_5278 
038D: draw_texture 1 position 35@ 36@(460@,5f) size 330.0 64.0 RGBA 50 50 50 255 

:OTB_5278
0087: 41@ = 35@ 
41@ -= 130.0 
0087: 42@ = 36@(460@,5f) 
42@ -= 8.0 
0085: 461@ = 460@ 
461@ += 4 
038D: draw_texture 461@ position 41@ 42@ size 64.0 64.0 RGBA 150 150 150 255 
0087: 43@ = 35@ 
43@ -= 105.0 
0087: 44@ = 36@(460@,5f) 
44@ -= 24.0 
gosub @OTB_13568 
033F: set_text_draw_letter_size 0.63 3.0 
if 
  65@(460@,5i) == 1 
else_jump @OTB_5477 
0904: get_interface 0 color_RGBA_to 462@ 463@ 464@ 465@ 
0340: set_text_draw_RGBA 462@ 463@ 464@ 465@ 

:OTB_5477
0085: 461@ = 443@(460@,5i) 
033E: set_draw_text_position 43@ 44@ GXT 97@(461@,167s) 
43@ += 254.2121 
gosub @OTB_13568 
033F: set_text_draw_letter_size 0.7 3.0 
03E4: set_text_draw_align_right 1 
if 
  65@(460@,5i) == 1 
else_jump @OTB_5589 
0904: get_interface 0 color_RGBA_to 462@ 463@ 464@ 465@ 
0340: set_text_draw_RGBA 462@ 463@ 464@ 465@ 

:OTB_5589
045A: draw_text_1number 43@ 44@ GXT 'ODDS' number 448@(460@,5i)  
460@ += 1 
jump @OTB_5089 

:OTB_5627
if 
  76@ == 1 
else_jump @OTB_6831 
if 
00E1:   player 0 pressed_key 15 
else_jump @OTB_6029 
if 
  75@ == 0 
else_jump @OTB_6022 
if 
  65@ == 1 
else_jump @OTB_5726 
66@ = 0 
67@ = 0 
68@ = 0 
69@ = 0 

:OTB_5726
if 
  66@ == 1 
else_jump @OTB_5772 
65@ = 0 
67@ = 0 
68@ = 0 
69@ = 0 

:OTB_5772
if 
  67@ == 1 
else_jump @OTB_5818 
65@ = 0 
66@ = 0 
68@ = 0 
69@ = 0 

:OTB_5818
if 
  68@ == 1 
else_jump @OTB_5864 
65@ = 0 
66@ = 0 
67@ = 0 
69@ = 0 

:OTB_5864
if 
  69@ == 1 
else_jump @OTB_5910 
65@ = 0 
66@ = 0 
67@ = 0 
68@ = 0 

:OTB_5910
75@ = 1 
78@ = 0 
79@ = 0 
80@ = 0 
81@ = 0 
82@ = 0 
83@ = 0 
84@ = 0 
85@ = 0 
86@ = 0 
76@ -= 1 
Player.Money(" + PlayerChar + @") += 87@
87@ = 0 
097A: play_audio_at 0.0 0.0 0.0 event 1121 

:OTB_6022
jump @OTB_6036 

:OTB_6029
75@ = 0 

:OTB_6036
if 
00E1:   player 0 pressed_key 16 
else_jump @OTB_6454 
if 
  74@ == 0 
else_jump @OTB_6447 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @OTB_6101 
Actor.StorePos(" + PlayerActor + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")

:OTB_6101
if and
  86@ > 0 
  87@ > 0 
else_jump @OTB_6153 
097A: play_audio_at 0.0 0.0 0.0 event 1123 
453@ = 1 

:OTB_6153
if 
  78@ == 1 
else_jump @OTB_6214 
78@ = 2 
Player.Money(" + PlayerChar + @") += 87@
0085: 87@ = 88@ 
097A: play_audio_at 0.0 0.0 0.0 event 1120 

:OTB_6214
460@ = 1 

:OTB_6221
if 
  8 > 460@ 
else_jump @OTB_6440 
if 
  78@(460@,8i) == 1 
else_jump @OTB_6426 
78@(460@,8i) = 2 
0085: 461@ = 88@(460@,8i) 
461@ -= 1 
0085: 466@ = 87@ 
005A: 466@ += 88@(460@,8i) 
if and
   Player.Money(" + PlayerChar + @") > 461@
  9999999 > 466@ 
else_jump @OTB_6406 
005A: 87@ += 88@(460@,8i) 
0085: 461@ = 88@(460@,8i) 
461@ *= -1 
Player.Money(" + PlayerChar + @") += 461@
097A: play_audio_at 0.0 0.0 0.0 event 1121 
jump @OTB_6426 

:OTB_6406
097A: play_audio_at 0.0 0.0 0.0 event 1158 

:OTB_6426
460@ += 1 
jump @OTB_6221 

:OTB_6440
74@ = 1 

:OTB_6447
jump @OTB_6831 

:OTB_6454
if 
  74@ == 1 
else_jump @OTB_6551 
460@ = 0 

:OTB_6479
if 
  8 > 460@ 
else_jump @OTB_6544 
if 
  78@(460@,8i) == 2 
else_jump @OTB_6530 
78@(460@,8i) = 1 

:OTB_6530
460@ += 1 
jump @OTB_6479 

:OTB_6544
74@ = 0 

:OTB_6551
if or
  -100 > 456@ 
00E1:   player 0 pressed_key 10 
else_jump @OTB_6614 
if 
  72@ == 0 
else_jump @OTB_6607 
72@ = 1 
gosub @OTB_13636 

:OTB_6607
jump @OTB_6621 

:OTB_6614
72@ = 0 

:OTB_6621
if or
  456@ > 100 
00E1:   player 0 pressed_key 11 
else_jump @OTB_6684 
if 
  73@ == 0 
else_jump @OTB_6677 
73@ = 1 
gosub @OTB_13774 

:OTB_6677
jump @OTB_6691 

:OTB_6684
73@ = 0 

:OTB_6691
if or
  -100 > 457@ 
00E1:   player 0 pressed_key 8 
else_jump @OTB_6754 
if 
  70@ == 0 
else_jump @OTB_6747 
70@ = 1 
gosub @OTB_13912 

:OTB_6747
jump @OTB_6761 

:OTB_6754
70@ = 0 

:OTB_6761
if or
  457@ > 100 
00E1:   player 0 pressed_key 9 
else_jump @OTB_6824 
if 
  71@ == 0 
else_jump @OTB_6817 
71@ = 1 
gosub @OTB_14182 

:OTB_6817
jump @OTB_6831 

:OTB_6824
71@ = 0 

:OTB_6831
460@ = 0 

:OTB_6838
if 
  8 > 460@ 
else_jump @OTB_7181 
if 
  78@(460@,8i) == 0 
else_jump @OTB_6918 
038D: draw_texture 2 position 47@(460@,8f) 55@(460@,8f) size 90.0 64.0 RGBA 150 150 150 255 

:OTB_6918
if 
  78@(460@,8i) == 1 
else_jump @OTB_6980 
038D: draw_texture 11 position 47@(460@,8f) 55@(460@,8f) size 90.0 64.0 RGBA 150 150 150 255 

:OTB_6980
if 
  78@(460@,8i) == 2 
else_jump @OTB_7042 
038D: draw_texture 3 position 47@(460@,8f) 55@(460@,8f) size 90.0 64.0 RGBA 150 150 150 255 

:OTB_7042
gosub @OTB_13568 
0342: set_text_draw_centered 1 
033F: set_text_draw_letter_size 0.58 2.4957 
0087: 467@ = 55@(460@,8f) 
467@ -= 28.3404 
if 
  78@(460@,8i) > 0 
else_jump @OTB_7139 
0904: get_interface 0 color_RGBA_to 462@ 463@ 464@ 465@ 
0340: set_text_draw_RGBA 462@ 463@ 464@ 465@ 

:OTB_7139
045A: draw_text_1number 47@(460@,8f) 467@ GXT 'DOLLAR' number 88@(460@,8i)  
460@ += 1 
jump @OTB_6838 

:OTB_7181
if 
  86@ == 0 
else_jump @OTB_7300 
if 
  87@ > 0 
else_jump @OTB_7260 
038D: draw_texture 1 position 510.0702 373.3544 size 176.8987 50.8555 RGBA 150 150 150 255 
jump @OTB_7293 

:OTB_7260
038D: draw_texture 1 position 510.0702 373.3544 size 176.8987 50.8555 RGBA 50 50 50 255 

:OTB_7293
jump @OTB_7336 

:OTB_7300
038D: draw_texture 10 position 510.0702 373.3544 size 176.8987 50.8555 RGBA 150 150 150 255 

:OTB_7336
gosub @OTB_13568 
if or
04A3:   " + Current_Language + @" == 2 
04A3:   " + Current_Language + @" == 3 
else_jump @OTB_7387 
033F: set_text_draw_letter_size 0.5 2.996 
jump @OTB_7399 

:OTB_7387
033F: set_text_draw_letter_size 0.609 2.996 

:OTB_7399
0342: set_text_draw_centered 1 
if 
  86@ > 0 
else_jump @OTB_7451 
0904: get_interface 0 color_RGBA_to 462@ 463@ 464@ 465@ 
0340: set_text_draw_RGBA 462@ 463@ 464@ 465@ 

:OTB_7451
033E: set_draw_text_position 509.6968 351.0 GXT 'PLACBET'  
gosub @OTB_13568 
033F: set_text_draw_letter_size 0.8 3.3297 
0342: set_text_draw_centered 1 
045A: draw_text_1number 509.2133 84.9941 GXT 'DOLLAR' number 87@  
if 
  453@ == 1 
else_jump @OTB_7544 
jump @OTB_7551 

:OTB_7544
jump @OTB_3828 

:OTB_7551
0391: release_textures 
0390: load_txd_dictionary 'LD_OTB' 
038F: load_texture ""BCKGRND"" as 1 
038F: load_texture ""BUSHES"" as 2 
038F: load_texture ""BRIDE1"" as 3 
038F: load_texture ""BRIDE2"" as 4 
038F: load_texture ""BRIDE3"" as 5 
038F: load_texture ""BRIDE4"" as 6 
038F: load_texture ""BRIDE5"" as 7 
038F: load_texture ""BRIDE6"" as 8 
038F: load_texture ""BRIDE7"" as 9 
038F: load_texture ""BRIDE8"" as 10 
038F: load_texture ""TREES"" as 11 
038F: load_texture ""FEN"" as 12 
038F: load_texture ""POLE2"" as 13 
038F: load_texture ""RRIDE1"" as 14 
038F: load_texture ""RRIDE2"" as 15 
038F: load_texture ""RRIDE3"" as 16 
038F: load_texture ""RRIDE4"" as 17 
038F: load_texture ""RRIDE5"" as 18 
038F: load_texture ""RRIDE6"" as 19 
038F: load_texture ""RRIDE7"" as 20 
038F: load_texture ""RRIDE8"" as 21 
038F: load_texture ""YRIDE1"" as 22 
038F: load_texture ""YRIDE2"" as 23 
038F: load_texture ""YRIDE3"" as 24 
038F: load_texture ""YRIDE4"" as 25 
038F: load_texture ""YRIDE5"" as 26 
038F: load_texture ""YRIDE6"" as 27 
038F: load_texture ""YRIDE7"" as 28 
038F: load_texture ""YRIDE8"" as 29 
038F: load_texture ""PRIDE1"" as 30 
038F: load_texture ""PRIDE2"" as 31 
038F: load_texture ""PRIDE3"" as 32 
038F: load_texture ""PRIDE4"" as 33 
038F: load_texture ""PRIDE5"" as 34 
038F: load_texture ""PRIDE6"" as 35 
038F: load_texture ""PRIDE7"" as 36 
038F: load_texture ""PRIDE8"" as 37 
038F: load_texture ""GRIDE1"" as 38 
038F: load_texture ""GRIDE2"" as 39 
038F: load_texture ""GRIDE3"" as 40 
038F: load_texture ""GRIDE4"" as 41 
038F: load_texture ""GRIDE5"" as 42 
038F: load_texture ""GRIDE6"" as 43 
038F: load_texture ""GRIDE7"" as 44 
038F: load_texture ""GRIDE8"" as 45 
038F: load_texture ""TVCORN"" as 46 
038F: load_texture ""TVL"" as 47 
038F: load_texture ""TVR"" as 48 
038F: load_texture ""BLUE"" as 49 
038F: load_texture ""HRS1"" as 50 
038F: load_texture ""HRS2"" as 51 
038F: load_texture ""HRS3"" as 52 
038F: load_texture ""HRS4"" as 53 
038F: load_texture ""HRS5"" as 54 
038F: load_texture ""HRS6"" as 55 
038F: load_texture ""HRS7"" as 56 
038F: load_texture ""HRS8"" as 57 
468@ = 0 
469@ = 0 
470@ = 0 
471@ = 0 
472@ = 0 
473@ = 0 
474@ = 0 
475@ = 0 
476@ = 0 
477@ = 0 
482@ = 128.0 
0087: 483@ = 482@ 
483@ /= 10.0 
0087: 481@ = 482@ 
0063: 481@ -= 483@ 
0087: 483@ = 481@ 
483@ /= 10.0 
0087: 480@ = 481@ 
0063: 480@ -= 483@ 
0087: 483@ = 480@ 
483@ /= 10.0 
0087: 479@ = 480@ 
0063: 479@ -= 483@ 
0087: 483@ = 479@ 
483@ /= 10.0 
0087: 478@ = 479@ 
0063: 478@ -= 483@ 
488@ = 64.0 
0087: 483@ = 488@ 
483@ /= 10.0 
0087: 487@ = 488@ 
0063: 487@ -= 483@ 
0087: 483@ = 487@ 
483@ /= 10.0 
0087: 486@ = 487@ 
0063: 486@ -= 483@ 
0087: 483@ = 486@ 
483@ /= 10.0 
0087: 485@ = 486@ 
0063: 485@ -= 483@ 
0087: 483@ = 485@ 
483@ /= 10.0 
0087: 484@ = 485@ 
0063: 484@ -= 483@ 
489@ = 150.0 
490@ = 150.0 
491@ = 150.0 
492@ = 150.0 
493@ = 150.0 
498@ = 300.0 
0087: 483@ = 498@ 
483@ /= 10.0 
0087: 497@ = 498@ 
0063: 497@ -= 483@ 
0087: 483@ = 497@ 
483@ /= 10.0 
0087: 496@ = 497@ 
0063: 496@ -= 483@ 
0087: 483@ = 496@ 
483@ /= 10.0 
0087: 495@ = 496@ 
0063: 495@ -= 483@ 
0087: 483@ = 495@ 
483@ /= 10.0 
0087: 494@ = 495@ 
0063: 494@ -= 483@ 
499@ = 159.0 
500@ = 159.0 
501@ = 159.0 
502@ = 159.0 
503@ = 159.0 
508@ = 261.0 
0087: 483@ = 508@ 
483@ /= 10.0 
0087: 507@ = 508@ 
0063: 507@ -= 483@ 
0087: 483@ = 507@ 
483@ /= 10.0 
0087: 506@ = 507@ 
0063: 506@ -= 483@ 
0087: 483@ = 506@ 
483@ /= 10.0 
0087: 505@ = 506@ 
0063: 505@ -= 483@ 
0087: 483@ = 505@ 
483@ /= 10.0 
0087: 504@ = 505@ 
0063: 504@ -= 483@ 
514@ = 0.0 
515@ = 0.0 
516@ = 0.0 
517@ = 0.0 
518@ = 0.0 
519@ = 2 
520@ = 5 
521@ = 6 
522@ = 1 
523@ = 4 
526@ = 3 
527@ = 14 
528@ = 22 
529@ = 30 
530@ = 38 
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
008B: 531@ = " + Current_Time_in_ms2 + @" 
531@ += 25000 
532@ = 512.0 
0087: 533@ = 532@ 
533@ += 124.0 
534@ = 0 
535@ = 0 
536@ = 0 
537@ = 0 
538@ = 0 
544@ = 0 
545@ = 0 
546@ = 0 
547@ = 0 
548@ = 0 
552@ = 0.0 
553@ = 0.0 
554@ = 0.0 
555@ = 0.0 
556@ = 0 
557@ = 454.364 
558@ = 152.8744 
563@ = 0 
564@ = 42 
569@ = 96 
574@ = 228 
565@ = 209 
570@ = 116 
575@ = 116 
566@ = 222 
571@ = 185 
576@ = 103 
567@ = 133 
572@ = 65 
577@ = 190 
568@ = 65 
573@ = 190 
578@ = 151 
097A: play_audio_at 0.0 0.0 0.0 event 1142 
579@ = 0 
580@ = 12 
581@ = 34 
582@ = 0 
583@ = 55 
584@ = 20 
038E: draw_box_position 320.0 224.0 size 640.0 448.0 RGBA 0 0 0 255 

:OTB_9493
wait 0 
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
if 
  556@ == 0 
else_jump @OTB_9975 
460@ = 0 

:OTB_9527
if 
  5 > 460@ 
else_jump @OTB_9975 
if 
001E:   " + Current_Time_in_ms2 + @" > 468@(460@,5i) 
else_jump @OTB_9633 
0208: 509@(460@,5f) = random_float_in_ranges -0.8 1.0 
0209: 585@ = random_int_in_ranges 1500 2500 
008B: 468@(460@,5i) = " + Current_Time_in_ms2 + @" 
005A: 468@(460@,5i) += 585@ 
473@(460@,5i) = 1 

:OTB_9633
if 
  473@(460@,5i) == 1 
else_jump @OTB_9845 
if 
0025:   514@(460@,5f) > 509@(460@,5f) 
else_jump @OTB_9750 
007F: 514@(460@,5f) -= frame_delta_time * 0.01 
if 
0025:   509@(460@,5f) > 514@(460@,5f) 
else_jump @OTB_9750 
0087: 514@(460@,5f) = 509@(460@,5f) 
473@(460@,5i) += 1 

:OTB_9750
if 
0025:   509@(460@,5f) > 514@(460@,5f) 
else_jump @OTB_9845 
0079: 514@(460@,5f) += frame_delta_time * 0.01 
if 
0025:   514@(460@,5f) > 509@(460@,5f) 
else_jump @OTB_9845 
0087: 514@(460@,5f) = 509@(460@,5f) 
473@(460@,5i) += 1 

:OTB_9845
if 
  473@(460@,5i) > 0 
else_jump @OTB_9883 
007B: 489@(460@,5f) += frame_delta_time * 514@(460@,5f) 

:OTB_9883
if 
  80.0 > 489@(460@,5f) 
else_jump @OTB_9922 
489@(460@,5f) = 80.0 

:OTB_9922
if 
  489@(460@,5f) > 520.0 
else_jump @OTB_9961 
489@(460@,5f) = 520.0 

:OTB_9961
460@ += 1 
jump @OTB_9527 

:OTB_9975
0087: 549@ = 552@ 
588@ = -76.0 
587@ = 72.0 
525@ = 1 
551@ = 4.0 
gosub @OTB_13313 
0087: 552@ = 549@ 
0087: 549@ = 554@ 
588@ = -64.0 
587@ = 128.0 
525@ = 2 
551@ = 5.0 
gosub @OTB_13313 
0087: 554@ = 549@ 
0087: 549@ = 553@ 
588@ = 0.0 
587@ = 256.0 
525@ = 11 
551@ = 6.0 
gosub @OTB_13313 
0087: 553@ = 549@ 
if 
001E:   " + Current_Time_in_ms2 + @" > 531@ 
else_jump @OTB_10594 
if 
  532@ > -200.0 
else_jump @OTB_10275 
if 
  556@ == 0 
else_jump @OTB_10223 
007F: 532@ -= frame_delta_time * 6.0 

:OTB_10223
038D: draw_texture 13 position 532@ 224.0 size 256.0 256.0 RGBA 150 150 150 255 
0087: 533@ = 532@ 
533@ += 124.0 

:OTB_10275
460@ = 0 

:OTB_10282
if 
  5 > 460@ 
else_jump @OTB_10594 
if 
  534@(460@,5i) == 0 
else_jump @OTB_10580 
if 
0025:   489@(460@,5f) > 533@ 
else_jump @OTB_10580 
if 
  544@ == 0 
else_jump @OTB_10388 
534@(460@,5i) = 1 
544@ += 1 
jump @OTB_10580 

:OTB_10388
if 
  545@ == 0 
else_jump @OTB_10431 
534@(460@,5i) = 2 
545@ += 1 
jump @OTB_10580 

:OTB_10431
if 
  546@ == 0 
else_jump @OTB_10474 
534@(460@,5i) = 3 
546@ += 1 
jump @OTB_10580 

:OTB_10474
if 
  547@ == 0 
else_jump @OTB_10517 
534@(460@,5i) = 4 
547@ += 1 
jump @OTB_10580 

:OTB_10517
if 
  548@ == 0 
else_jump @OTB_10580 
534@(460@,5i) = 5 
097A: play_audio_at 0.0 0.0 0.0 event 1143 
556@ += 1 
548@ += 1 

:OTB_10580
460@ += 1 
jump @OTB_10282 

:OTB_10594
460@ = 0 

:OTB_10601
if 
  5 > 460@ 
else_jump @OTB_10922 
524@ = 50 
005A: 524@ += 519@(460@,5i) 
038D: draw_texture 524@ position 489@(460@,5f) 494@(460@,5f) size 478@(460@,5f) 478@(460@,5f) RGBA 150 150 150 255 
0085: 524@ = 526@(460@,5i) 
005A: 524@ += 519@(460@,5i) 
0087: 499@(460@,5f) = 489@(460@,5f) 
499@(460@,5f) += 9.0 
0087: 467@ = 484@(460@,5f) 
467@ /= 2.0 
038D: draw_texture 524@ position 499@(460@,5f) 504@(460@,5f) size 484@(460@,5f) 467@ RGBA 150 150 150 255 
if 
  556@ == 0 
else_jump @OTB_10908 
if 
001E:   " + Current_Time_in_ms2 + @" > 580@(460@,5i) 
else_jump @OTB_10908 
519@(460@,5i) += 1 
if 
  519@(460@,5i) > 7 
else_jump @OTB_10885 
519@(460@,5i) = 0 

:OTB_10885
008B: 580@(460@,5i) = " + Current_Time_in_ms2 + @" 
580@(460@,5i) += 67 

:OTB_10908
460@ += 1 
jump @OTB_10601 

:OTB_10922
0087: 549@ = 555@ 
588@ = 96.0 
587@ = 64.0 
525@ = 12 
551@ = 8.0 
gosub @OTB_13313 
0087: 555@ = 549@ 
038D: draw_texture 46 position 160.0 112.0 size 320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 46 position 480.0 112.0 size -320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 46 position 480.0 336.0 size -320.0 -224.0 RGBA 150 150 150 255 
038D: draw_texture 46 position 160.0 336.0 size 320.0 -224.0 RGBA 150 150 150 255 
038D: draw_texture 47 position 160.0 0.0 size 320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 47 position 160.0 448.0 size 320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 48 position 480.0 0.0 size 320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 48 position 480.0 448.0 size 320.0 224.0 RGBA 150 150 150 255 
if or
  534@ > 0 
  535@ > 0 
  536@ > 0 
  537@ > 0 
  538@ > 0 
else_jump @OTB_11386 
0087: 561@ = 557@ 
561@ += -25.0222 
0087: 562@ = 558@ 
562@ += 21.6946 
038E: draw_box_position 561@ 562@ size 355.0807 119.5942 RGBA 47 62 90 200 
jump @OTB_11795 

:OTB_11386
0087: 561@ = 557@ 
561@ += -139.2772 
0087: 562@ = 558@ 
562@ += -56.1882 
038D: draw_texture 49 position 561@ 562@ size 280.2137 22.6679 RGBA 150 150 150 255 
0087: 559@ = 557@ 
559@ -= 157.3474 
0087: 560@ = 558@ 
560@ -= 68.5107 
gosub @OTB_13568 
0341: set_text_draw_align_justify 0 
03E4: set_text_draw_align_right 1 
033E: set_draw_text_position 559@ 560@ GXT 'YOURHSE'  
0087: 559@ = 557@ 
559@ -= 142.4242 
560@ += 12.7439 
038E: draw_box_position 559@ 560@ size 12.0 12.0 RGBA 0 0 0 255 
460@ = 0 

:OTB_11584
if 
  5 > 460@ 
else_jump @OTB_11680 
if 
  65@(460@,5i) == 1 
else_jump @OTB_11666 
038E: draw_box_position 559@ 560@ size 10.0 10.0 RGBA 564@(460@,5i) 569@(460@,5i) 574@(460@,5i) 255 

:OTB_11666
460@ += 1 
jump @OTB_11584 

:OTB_11680
559@ += 10.8216 
560@ -= 12.7439 
gosub @OTB_13568 
460@ = 0 

:OTB_11714
if 
  5 > 460@ 
else_jump @OTB_11795 
if 
  65@(460@,5i) == 1 
else_jump @OTB_11781 
0085: 461@ = 443@(460@,5i) 
033E: set_draw_text_position 559@ 560@ GXT 97@(461@,167s) 

:OTB_11781
460@ += 1 
jump @OTB_11714 

:OTB_11795
0087: 586@ = 557@ 
586@ += -23.3585 
460@ = 0 

:OTB_11820
if 
  5 > 460@ 
else_jump @OTB_12617 
if 
  534@(460@,5i) > 0 
else_jump @OTB_12603 
0087: 559@ = 586@ 
559@ -= 50.0 
0087: 560@ = 558@ 
560@ -= 50.0 
0093: 467@ = integer 534@(460@,5i) to_float 
467@ *= 23.5038 
005B: 560@ += 467@ 
038E: draw_box_position 559@ 560@ size 12.0 12.0 RGBA 0 0 0 255 
038E: draw_box_position 559@ 560@ size 10.0 10.0 RGBA 564@(460@,5i) 569@(460@,5i) 574@(460@,5i) 255 
0087: 559@ = 586@ 
559@ -= 39.1244 
0087: 560@ = 558@ 
560@ -= 63.4833 
gosub @OTB_13568 
if 
  534@(460@,5i) == 1 
else_jump @OTB_12090 
0904: get_interface 0 color_RGBA_to 462@ 463@ 464@ 465@ 
0340: set_text_draw_RGBA 462@ 463@ 464@ 465@ 

:OTB_12090
0093: 467@ = integer 534@(460@,5i) to_float 
467@ *= 23.5038 
0087: 539@(460@,5f) = 560@ 
005B: 539@(460@,5f) += 467@ 
0085: 461@ = 443@(460@,5i) 
033F: set_text_draw_letter_size 0.54 2.4961 
033E: set_draw_text_position 559@ 539@(460@,5f) GXT 97@(461@,167s) 
if 
  65@(460@,5i) == 1 
else_jump @OTB_12267 
0087: 559@ = 586@ 
559@ -= 64.0 
gosub @OTB_13568 
0341: set_text_draw_align_justify 0 
03E4: set_text_draw_align_right 1 
033F: set_text_draw_letter_size 0.54 2.4961 
033E: set_draw_text_position 559@ 539@(460@,5f) GXT 'YOURHSE'  

:OTB_12267
0087: 559@ = 586@ 
559@ -= -170.5457 
0087: 560@ = 558@ 
560@ -= 63.4833 
gosub @OTB_13568 
03E4: set_text_draw_align_right 1 
if 
  534@(460@,5i) == 1 
else_jump @OTB_12366 
0904: get_interface 0 color_RGBA_to 462@ 463@ 464@ 465@ 
0340: set_text_draw_RGBA 462@ 463@ 464@ 465@ 

:OTB_12366
0093: 467@ = integer 534@(460@,5i) to_float 
467@ *= 23.5038 
0087: 539@(460@,5f) = 560@ 
005B: 539@(460@,5f) += 467@ 
033F: set_text_draw_letter_size 0.54 2.4961 
if 
  534@(460@,5i) == 1 
else_jump @OTB_12467 
033E: set_draw_text_position 559@ 539@(460@,5f) GXT 'FIRST'  

:OTB_12467
if 
  534@(460@,5i) == 2 
else_jump @OTB_12510 
033E: set_draw_text_position 559@ 539@(460@,5f) GXT 'SECOND'  

:OTB_12510
if 
  534@(460@,5i) == 3 
else_jump @OTB_12553 
033E: set_draw_text_position 559@ 539@(460@,5f) GXT 'THIRD'  

:OTB_12553
if 
  534@(460@,5i) > 3 
else_jump @OTB_12603 
045A: draw_text_1number 559@ 539@(460@,5f) GXT 'NTH' number 534@(460@,5i)  

:OTB_12603
460@ += 1 
jump @OTB_11820 

:OTB_12617
if and
  534@ > 0 
  535@ > 0 
  536@ > 0 
  537@ > 0 
  538@ > 0 
else_jump @OTB_13286 
0087: 561@ = 557@ 
561@ += 44.4599 
0087: 562@ = 558@ 
562@ += 218.4174 
038D: draw_texture 49 position 561@ 562@ size 155.396 52.7081 RGBA 150 150 150 255 
0087: 559@ = 557@ 
559@ -= 39.2243 
0087: 560@ = 558@ 
560@ -= -190.9665 
gosub @OTB_13568 
033F: set_text_draw_letter_size 0.5 2.4961 
045A: draw_text_1number 559@ 560@ GXT 'YOURSTK' number 87@  
460@ = 0 

:OTB_12813
if 
  5 > 460@ 
else_jump @OTB_12898 
if and
  534@(460@,5i) == 1 
  65@(460@,5i) == 1 
else_jump @OTB_12884 
0085: 563@ = 87@ 
006A: 563@ *= 448@(460@,5i) 

:OTB_12884
460@ += 1 
jump @OTB_12813 

:OTB_12898
560@ += 25.0 
gosub @OTB_13568 
033F: set_text_draw_letter_size 0.5 2.4961 
045A: draw_text_1number 559@ 560@ GXT 'YOUWIN' number 563@  
0087: 561@ = 557@ 
561@ += -129.2806 
0087: 562@ = 558@ 
562@ += 259.5944 
038D: draw_texture 49 position 561@ 562@ size 239.5561 12.6761 RGBA 150 150 150 255 
gosub @OTB_13568 
033F: set_text_draw_letter_size 0.5496 2.1344 
0342: set_text_draw_centered 1 
033E: set_draw_text_position 330.2087 403.5891 GXT 'XTOCONT'  
if 
  579@ == 0 
else_jump @OTB_13149 
if 
  563@ > 0 
else_jump @OTB_13122 
097A: play_audio_at 0.0 0.0 0.0 event 1124 
jump @OTB_13142 

:OTB_13122
097A: play_audio_at 0.0 0.0 0.0 event 1122 

:OTB_13142
579@ = 1 

:OTB_13149
if 
00E1:   player 0 pressed_key 16 
else_jump @OTB_13279 
if 
  74@ == 0 
else_jump @OTB_13272 
74@ = 1 
0623: add 87@ to_integer_stat 35 
if 
  563@ > 0 
else_jump @OTB_13253 
0627: update_integer_stat 38 to 563@ 
0623: add 563@ to_integer_stat 37 
005A: 563@ += 87@ 
Player.Money(" + PlayerChar + @") += 563@
jump @OTB_13260 

:OTB_13253
0627: update_integer_stat 39 to 87@ 

:OTB_13260
fade 0 0 
wait 0 
return 

:OTB_13272
jump @OTB_13286 

:OTB_13279
74@ = 0 

:OTB_13286
jump @OTB_9493 

:OTB_13293
0391: release_textures 
fade 1 500 
" + OnMission + @" = 0 
mission_cleanup 
return 

:OTB_13313
588@ += 224.0 
0087: 550@ = 549@ 
550@ -= 256.0 
038D: draw_texture 525@ position 550@ 588@ size 256.0 587@ RGBA 150 150 150 255 
0087: 550@ = 549@ 
038D: draw_texture 525@ position 550@ 588@ size 256.0 587@ RGBA 150 150 150 255 
0087: 550@ = 549@ 
550@ += 256.0 
038D: draw_texture 525@ position 550@ 588@ size 256.0 587@ RGBA 150 150 150 255 
0087: 550@ = 549@ 
550@ += 512.0 
038D: draw_texture 525@ position 550@ 588@ size 256.0 587@ RGBA 150 150 150 255 
if 
  556@ == 0 
else_jump @OTB_13535 
0081: 549@ -= frame_delta_time * 551@ 

:OTB_13535
if 
  0.0 > 549@ 
else_jump @OTB_13566 
549@ += 256.0 

:OTB_13566
return 

:OTB_13568
0340: set_text_draw_RGBA 180 180 180 255 
033F: set_text_draw_letter_size 0.6146 2.4961 
03E4: set_text_draw_align_right 0 
0341: set_text_draw_align_justify 0 
0342: set_text_draw_centered 0 
0343: set_text_draw_linewidth 640.0 
0348: enable_text_draw_proportional 1 
0345: enable_text_draw_background 0 
060D: draw_text_shadow 2 rgba 0 0 0 180 
return 

:OTB_13636
if 
  79@ == 1 
else_jump @OTB_13670 
79@ = 0 
78@ = 1 
return 

:OTB_13670
if 
  81@ == 1 
else_jump @OTB_13704 
81@ = 0 
80@ = 1 
return 

:OTB_13704
if 
  83@ == 1 
else_jump @OTB_13738 
83@ = 0 
82@ = 1 
return 

:OTB_13738
if 
  85@ == 1 
else_jump @OTB_13772 
85@ = 0 
84@ = 1 
return 

:OTB_13772
return 

:OTB_13774
if 
  78@ == 1 
else_jump @OTB_13808 
78@ = 0 
79@ = 1 
return 

:OTB_13808
if 
  80@ == 1 
else_jump @OTB_13842 
80@ = 0 
81@ = 1 
return 

:OTB_13842
if 
  82@ == 1 
else_jump @OTB_13876 
82@ = 0 
83@ = 1 
return 

:OTB_13876
if 
  84@ == 1 
else_jump @OTB_13910 
84@ = 0 
85@ = 1 
return 

:OTB_13910
return 

:OTB_13912
if 
  80@ == 1 
else_jump @OTB_13946 
80@ = 0 
78@ = 1 
return 

:OTB_13946
if 
  81@ == 1 
else_jump @OTB_13980 
81@ = 0 
79@ = 1 
return 

:OTB_13980
if 
  82@ == 1 
else_jump @OTB_14014 
82@ = 0 
80@ = 1 
return 

:OTB_14014
if 
  83@ == 1 
else_jump @OTB_14048 
83@ = 0 
81@ = 1 
return 

:OTB_14048
if 
  84@ == 1 
else_jump @OTB_14082 
84@ = 0 
82@ = 1 
return 

:OTB_14082
if 
  85@ == 1 
else_jump @OTB_14116 
85@ = 0 
83@ = 1 
return 

:OTB_14116
if 
  86@ == 1 
else_jump @OTB_14148 
86@ = 0 
84@ = 1 

:OTB_14148
if 
  86@ == 2 
else_jump @OTB_14180 
86@ = 0 
85@ = 1 

:OTB_14180
return 

:OTB_14182
if 
  78@ == 1 
else_jump @OTB_14216 
78@ = 0 
80@ = 1 
return 

:OTB_14216
if 
  79@ == 1 
else_jump @OTB_14250 
79@ = 0 
81@ = 1 
return 

:OTB_14250
if 
  80@ == 1 
else_jump @OTB_14284 
80@ = 0 
82@ = 1 
return 

:OTB_14284
if 
  81@ == 1 
else_jump @OTB_14318 
81@ = 0 
83@ = 1 
return 

:OTB_14318
if 
  82@ == 1 
else_jump @OTB_14352 
82@ = 0 
84@ = 1 
return 

:OTB_14352
if 
  83@ == 1 
else_jump @OTB_14386 
83@ = 0 
85@ = 1 
return 

:OTB_14386
if 
  87@ > 0 
else_jump @OTB_14472 
if 
  84@ == 1 
else_jump @OTB_14438 
84@ = 0 
86@ = 1 
return 

:OTB_14438
if 
  85@ == 1 
else_jump @OTB_14472 
85@ = 0 
86@ = 2 
return 

:OTB_14472
return" );
            }

        }

    }

}