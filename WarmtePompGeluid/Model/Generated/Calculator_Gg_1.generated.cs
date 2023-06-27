using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Ambacht.Common.Excel;

namespace WarmtePompGeluid.Model.Generated;

public class Calculator_Gg_1 : ExcelCalculatorBase {

	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object C85 {
		get => this[Addresses.C85];
		set => this[Addresses.C85] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object C86 {
		get => this[Addresses.C86];
		set => this[Addresses.C86] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object C87 {
		get => this[Addresses.C87];
		set => this[Addresses.C87] = value;
	}


	/// <summary>
	/// C85+C86-C87
	/// </summary>
	public object C88 {
		get => this[Addresses.C88];
		set => this[Addresses.C88] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object F85 {
		get => this[Addresses.F85];
		set => this[Addresses.F85] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object F86 {
		get => this[Addresses.F86];
		set => this[Addresses.F86] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object F87 {
		get => this[Addresses.F87];
		set => this[Addresses.F87] = value;
	}


	/// <summary>
	/// F85+F86-F87
	/// </summary>
	public object F88 {
		get => this[Addresses.F88];
		set => this[Addresses.F88] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B16 {
		get => this[Addresses.B16];
		set => this[Addresses.B16] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object C35 {
		get => this[Addresses.C35];
		set => this[Addresses.C35] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B15 {
		get => this[Addresses.B15];
		set => this[Addresses.B15] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B11 {
		get => this[Addresses.B11];
		set => this[Addresses.B11] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B12 {
		get => this[Addresses.B12];
		set => this[Addresses.B12] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object C36 {
		get => this[Addresses.C36];
		set => this[Addresses.C36] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B13 {
		get => this[Addresses.B13];
		set => this[Addresses.B13] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object C37 {
		get => this[Addresses.C37];
		set => this[Addresses.C37] = value;
	}


	/// <summary>
	/// SQRT(((B11-C35)^2)+((B12-C36)^2)+((B13-C37)^2))
	/// </summary>
	public object C61 {
		get => this[Addresses.C61];
		set => this[Addresses.C61] = value;
	}


	/// <summary>
	/// variable (String)
	/// </summary>
	public object C38 {
		get => this[Addresses.C38];
		set => this[Addresses.C38] = value;
	}


	/// <summary>
	/// IF((C38="J"),5,0)
	/// </summary>
	public object C62 {
		get => this[Addresses.C62];
		set => this[Addresses.C62] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object C39 {
		get => this[Addresses.C39];
		set => this[Addresses.C39] = value;
	}


	/// <summary>
	/// 10*LOG10(2/C39)
	/// </summary>
	public object C63 {
		get => this[Addresses.C63];
		set => this[Addresses.C63] = value;
	}


	/// <summary>
	/// 20*LOG10(C61)+9+C62-C63
	/// </summary>
	public object C64 {
		get => this[Addresses.C64];
		set => this[Addresses.C64] = value;
	}


	/// <summary>
	/// IF(C35="nvt","",ROUND(45+C64,0))
	/// </summary>
	public object C50 {
		get => this[Addresses.C50];
		set => this[Addresses.C50] = value;
	}


	/// <summary>
	/// IF(C50<>"",-C50,-9999)
	/// </summary>
	public object C52 {
		get => this[Addresses.C52];
		set => this[Addresses.C52] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object C67 {
		get => this[Addresses.C67];
		set => this[Addresses.C67] = value;
	}


	/// <summary>
	/// variable (String)
	/// </summary>
	public object I21 {
		get => this[Addresses.I21];
		set => this[Addresses.I21] = value;
	}


	/// <summary>
	/// IF(I21="j",1,0)
	/// </summary>
	public object L20 {
		get => this[Addresses.L20];
		set => this[Addresses.L20] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B31 {
		get => this[Addresses.B31];
		set => this[Addresses.B31] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B32 {
		get => this[Addresses.B32];
		set => this[Addresses.B32] = value;
	}


	/// <summary>
	/// B15
	/// </summary>
	public object AB12 {
		get => this[Addresses.AB12];
		set => this[Addresses.AB12] = value;
	}


	/// <summary>
	/// variable (String)
	/// </summary>
	public object I19 {
		get => this[Addresses.I19];
		set => this[Addresses.I19] = value;
	}


	/// <summary>
	/// IF(I19="j",1,0)
	/// </summary>
	public object L112 {
		get => this[Addresses.L112];
		set => this[Addresses.L112] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B29 {
		get => this[Addresses.B29];
		set => this[Addresses.B29] = value;
	}


	/// <summary>
	/// B11
	/// </summary>
	public object X7 {
		get => this[Addresses.X7];
		set => this[Addresses.X7] = value;
	}


	/// <summary>
	/// B12
	/// </summary>
	public object Y7 {
		get => this[Addresses.Y7];
		set => this[Addresses.Y7] = value;
	}


	/// <summary>
	/// B13
	/// </summary>
	public object Z7 {
		get => this[Addresses.Z7];
		set => this[Addresses.Z7] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B59 {
		get => this[Addresses.B59];
		set => this[Addresses.B59] = value;
	}


	/// <summary>
	/// variable (Blank)
	/// </summary>
	public object BC20 {
		get => this[Addresses.BC20];
		set => this[Addresses.BC20] = value;
	}


	/// <summary>
	/// variable ()
	/// </summary>
	public object BB20 {
		get => this[Addresses.BB20];
		set => this[Addresses.BB20] = value;
	}


	/// <summary>
	/// IF(BC20=1,AB12-(20*LOG10(BB20))-9+(10*LOG10(1-B59)),-9999)
	/// </summary>
	public object BD20 {
		get => this[Addresses.BD20];
		set => this[Addresses.BD20] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B58 {
		get => this[Addresses.B58];
		set => this[Addresses.B58] = value;
	}


	/// <summary>
	/// variable (Blank)
	/// </summary>
	public object AV112 {
		get => this[Addresses.AV112];
		set => this[Addresses.AV112] = value;
	}


	/// <summary>
	/// variable ()
	/// </summary>
	public object AU112 {
		get => this[Addresses.AU112];
		set => this[Addresses.AU112] = value;
	}


	/// <summary>
	/// IF(AV112=1,AB12-(20*LOG10(AU112))-9+(10*LOG10(1-B59)),-9999)
	/// </summary>
	public object AW112 {
		get => this[Addresses.AW112];
		set => this[Addresses.AW112] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B20 {
		get => this[Addresses.B20];
		set => this[Addresses.B20] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B21 {
		get => this[Addresses.B21];
		set => this[Addresses.B21] = value;
	}


	/// <summary>
	/// +MIN(B20,B21)
	/// </summary>
	public object Z17 {
		get => this[Addresses.Z17];
		set => this[Addresses.Z17] = value;
	}


	/// <summary>
	/// +Z17
	/// </summary>
	public object X20 {
		get => this[Addresses.X20];
		set => this[Addresses.X20] = value;
	}


	/// <summary>
	/// IF(X20>B31,IF(X20<B32,1,""),"")
	/// </summary>
	public object AI20 {
		get => this[Addresses.AI20];
		set => this[Addresses.AI20] = value;
	}


	/// <summary>
	/// +MAX(B20,B21)
	/// </summary>
	public object AA17 {
		get => this[Addresses.AA17];
		set => this[Addresses.AA17] = value;
	}


	/// <summary>
	/// +AA17
	/// </summary>
	public object Y20 {
		get => this[Addresses.Y20];
		set => this[Addresses.Y20] = value;
	}


	/// <summary>
	/// +(AA17-Z17)/30
	/// </summary>
	public object Y15 {
		get => this[Addresses.Y15];
		set => this[Addresses.Y15] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B33 {
		get => this[Addresses.B33];
		set => this[Addresses.B33] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B27 {
		get => this[Addresses.B27];
		set => this[Addresses.B27] = value;
	}


	/// <summary>
	/// -X7
	/// </summary>
	public object AJ20 {
		get => this[Addresses.AJ20];
		set => this[Addresses.AJ20] = value;
	}


	/// <summary>
	/// Y7
	/// </summary>
	public object AK20 {
		get => this[Addresses.AK20];
		set => this[Addresses.AK20] = value;
	}


	/// <summary>
	/// Y7
	/// </summary>
	public object AR20 {
		get => this[Addresses.AR20];
		set => this[Addresses.AR20] = value;
	}


	/// <summary>
	/// X7+(Y7*(X20-X7)/(Y20+Y7))
	/// </summary>
	public object AG20 {
		get => this[Addresses.AG20];
		set => this[Addresses.AG20] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B30 {
		get => this[Addresses.B30];
		set => this[Addresses.B30] = value;
	}


	/// <summary>
	/// -X7
	/// </summary>
	public object AJ112 {
		get => this[Addresses.AJ112];
		set => this[Addresses.AJ112] = value;
	}


	/// <summary>
	/// Y7
	/// </summary>
	public object AK112 {
		get => this[Addresses.AK112];
		set => this[Addresses.AK112] = value;
	}


	/// <summary>
	/// X7
	/// </summary>
	public object AX112 {
		get => this[Addresses.AX112];
		set => this[Addresses.AX112] = value;
	}


	/// <summary>
	/// 2*B21-Y7
	/// </summary>
	public object AY112 {
		get => this[Addresses.AY112];
		set => this[Addresses.AY112] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B22 {
		get => this[Addresses.B22];
		set => this[Addresses.B22] = value;
	}


	/// <summary>
	/// +B22
	/// </summary>
	public object AB17 {
		get => this[Addresses.AB17];
		set => this[Addresses.AB17] = value;
	}


	/// <summary>
	/// IF(AI20<>1,AB17,B33+0.5)
	/// </summary>
	public object Z20 {
		get => this[Addresses.Z20];
		set => this[Addresses.Z20] = value;
	}


	/// <summary>
	/// +SQRT(((X7-X20)^2)+((Y20-Y7)^2)+((Z20-Z7)^2))
	/// </summary>
	public object AE20 {
		get => this[Addresses.AE20];
		set => this[Addresses.AE20] = value;
	}


	/// <summary>
	/// +AB12-(20*LOG10(AE20))-9
	/// </summary>
	public object AF20 {
		get => this[Addresses.AF20];
		set => this[Addresses.AF20] = value;
	}


	/// <summary>
	/// (((X20-AJ20)^2)+((Y20-AK20)^2)+((Z20-Z7)^2))^0.5
	/// </summary>
	public object AN20 {
		get => this[Addresses.AN20];
		set => this[Addresses.AN20] = value;
	}


	/// <summary>
	/// +SQRT(((X7-X20)^2)+((Y20+Y7)^2)+((Z20-Z7)^2))
	/// </summary>
	public object BE20 {
		get => this[Addresses.BE20];
		set => this[Addresses.BE20] = value;
	}


	/// <summary>
	/// X7/(X20+X7)
	/// </summary>
	public object AL20 {
		get => this[Addresses.AL20];
		set => this[Addresses.AL20] = value;
	}


	/// <summary>
	/// Y7+(AL20*(Y20-Y7))
	/// </summary>
	public object AM20 {
		get => this[Addresses.AM20];
		set => this[Addresses.AM20] = value;
	}


	/// <summary>
	/// IF((AM20<=B27),1,0)
	/// </summary>
	public object AO20 {
		get => this[Addresses.AO20];
		set => this[Addresses.AO20] = value;
	}


	/// <summary>
	/// IF((AO20=1),(AB12-(20*LOG10(AN20))-9+(10*LOG10(1-B59))),-9999)
	/// </summary>
	public object AP20 {
		get => this[Addresses.AP20];
		set => this[Addresses.AP20] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B19 {
		get => this[Addresses.B19];
		set => this[Addresses.B19] = value;
	}


	/// <summary>
	/// 2*B19-B11
	/// </summary>
	public object AQ20 {
		get => this[Addresses.AQ20];
		set => this[Addresses.AQ20] = value;
	}


	/// <summary>
	/// (((AQ20-X20)^2)+((AR20-Y20)^2)+((Z20-Z7)^2))^0.5
	/// </summary>
	public object AU20 {
		get => this[Addresses.AU20];
		set => this[Addresses.AU20] = value;
	}


	/// <summary>
	/// (-B19+X7)/(2*B19-X7-X20)
	/// </summary>
	public object AS20 {
		get => this[Addresses.AS20];
		set => this[Addresses.AS20] = value;
	}


	/// <summary>
	/// Y7+(AS20*(Y7-Y20))
	/// </summary>
	public object AT20 {
		get => this[Addresses.AT20];
		set => this[Addresses.AT20] = value;
	}


	/// <summary>
	/// IF(AT20<B29,1,0)
	/// </summary>
	public object AV20 {
		get => this[Addresses.AV20];
		set => this[Addresses.AV20] = value;
	}


	/// <summary>
	/// IF(AV20=1,AB12-(20*LOG10(AU20))-9+(10*LOG10(1-B59)),-9999)
	/// </summary>
	public object AW20 {
		get => this[Addresses.AW20];
		set => this[Addresses.AW20] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B24 {
		get => this[Addresses.B24];
		set => this[Addresses.B24] = value;
	}


	/// <summary>
	/// B24
	/// </summary>
	public object X10 {
		get => this[Addresses.X10];
		set => this[Addresses.X10] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B25 {
		get => this[Addresses.B25];
		set => this[Addresses.B25] = value;
	}


	/// <summary>
	/// B25
	/// </summary>
	public object Y10 {
		get => this[Addresses.Y10];
		set => this[Addresses.Y10] = value;
	}


	/// <summary>
	/// IF(AG20>=X10,IF(AG20<=Y10,1,""),"")
	/// </summary>
	public object AH20 {
		get => this[Addresses.AH20];
		set => this[Addresses.AH20] = value;
	}


	/// <summary>
	/// IF((B58<1),IF((AH20=1),+AB12-(20*LOG10(BE20))-9+(10*LOG10(1-B58)),-999),-999)
	/// </summary>
	public object BF20 {
		get => this[Addresses.BF20];
		set => this[Addresses.BF20] = value;
	}


	/// <summary>
	/// 10*LOG10((10^(AP20/10))+(10^(AW20/10))+(10^(BD20/10))+(10^(BF20/10)))
	/// </summary>
	public object BG20 {
		get => this[Addresses.BG20];
		set => this[Addresses.BG20] = value;
	}


	/// <summary>
	/// IF((L20=1),IF((AI20=1),ROUND(10*LOG10((10^(AF20/10))+(10^(BG20/10))),0),""),"")
	/// </summary>
	public object BJ20 {
		get => this[Addresses.BJ20];
		set => this[Addresses.BJ20] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B18 {
		get => this[Addresses.B18];
		set => this[Addresses.B18] = value;
	}


	/// <summary>
	/// +MAX(B18,B19)
	/// </summary>
	public object Y17 {
		get => this[Addresses.Y17];
		set => this[Addresses.Y17] = value;
	}


	/// <summary>
	/// +Y17
	/// </summary>
	public object X112 {
		get => this[Addresses.X112];
		set => this[Addresses.X112] = value;
	}


	/// <summary>
	/// X7/(X112+X7)
	/// </summary>
	public object AL112 {
		get => this[Addresses.AL112];
		set => this[Addresses.AL112] = value;
	}


	/// <summary>
	/// +Z17
	/// </summary>
	public object Y51 {
		get => this[Addresses.Y51];
		set => this[Addresses.Y51] = value;
	}


	/// <summary>
	/// +Y51
	/// </summary>
	public object Y82 {
		get => this[Addresses.Y82];
		set => this[Addresses.Y82] = value;
	}


	/// <summary>
	/// +Y82+Y15
	/// </summary>
	public object Y83 {
		get => this[Addresses.Y83];
		set => this[Addresses.Y83] = value;
	}


	/// <summary>
	/// +Y83+Y15
	/// </summary>
	public object Y84 {
		get => this[Addresses.Y84];
		set => this[Addresses.Y84] = value;
	}


	/// <summary>
	/// +Y84+Y15
	/// </summary>
	public object Y85 {
		get => this[Addresses.Y85];
		set => this[Addresses.Y85] = value;
	}


	/// <summary>
	/// +Y85+Y15
	/// </summary>
	public object Y86 {
		get => this[Addresses.Y86];
		set => this[Addresses.Y86] = value;
	}


	/// <summary>
	/// +Y86+Y15
	/// </summary>
	public object Y87 {
		get => this[Addresses.Y87];
		set => this[Addresses.Y87] = value;
	}


	/// <summary>
	/// +Y87+Y15
	/// </summary>
	public object Y88 {
		get => this[Addresses.Y88];
		set => this[Addresses.Y88] = value;
	}


	/// <summary>
	/// +Y88+Y15
	/// </summary>
	public object Y89 {
		get => this[Addresses.Y89];
		set => this[Addresses.Y89] = value;
	}


	/// <summary>
	/// +Y89+Y15
	/// </summary>
	public object Y90 {
		get => this[Addresses.Y90];
		set => this[Addresses.Y90] = value;
	}


	/// <summary>
	/// +Y90+Y15
	/// </summary>
	public object Y91 {
		get => this[Addresses.Y91];
		set => this[Addresses.Y91] = value;
	}


	/// <summary>
	/// +Y91+Y15
	/// </summary>
	public object Y92 {
		get => this[Addresses.Y92];
		set => this[Addresses.Y92] = value;
	}


	/// <summary>
	/// +Y92+Y15
	/// </summary>
	public object Y93 {
		get => this[Addresses.Y93];
		set => this[Addresses.Y93] = value;
	}


	/// <summary>
	/// +Y93+Y15
	/// </summary>
	public object Y94 {
		get => this[Addresses.Y94];
		set => this[Addresses.Y94] = value;
	}


	/// <summary>
	/// +Y94+Y15
	/// </summary>
	public object Y95 {
		get => this[Addresses.Y95];
		set => this[Addresses.Y95] = value;
	}


	/// <summary>
	/// +Y95+Y15
	/// </summary>
	public object Y96 {
		get => this[Addresses.Y96];
		set => this[Addresses.Y96] = value;
	}


	/// <summary>
	/// +Y96+Y15
	/// </summary>
	public object Y97 {
		get => this[Addresses.Y97];
		set => this[Addresses.Y97] = value;
	}


	/// <summary>
	/// +Y97+Y15
	/// </summary>
	public object Y98 {
		get => this[Addresses.Y98];
		set => this[Addresses.Y98] = value;
	}


	/// <summary>
	/// +Y98+Y15
	/// </summary>
	public object Y99 {
		get => this[Addresses.Y99];
		set => this[Addresses.Y99] = value;
	}


	/// <summary>
	/// +Y99+Y15
	/// </summary>
	public object Y100 {
		get => this[Addresses.Y100];
		set => this[Addresses.Y100] = value;
	}


	/// <summary>
	/// +Y100+Y15
	/// </summary>
	public object Y101 {
		get => this[Addresses.Y101];
		set => this[Addresses.Y101] = value;
	}


	/// <summary>
	/// +Y101+Y15
	/// </summary>
	public object Y102 {
		get => this[Addresses.Y102];
		set => this[Addresses.Y102] = value;
	}


	/// <summary>
	/// +Y102+Y15
	/// </summary>
	public object Y103 {
		get => this[Addresses.Y103];
		set => this[Addresses.Y103] = value;
	}


	/// <summary>
	/// +Y103+Y15
	/// </summary>
	public object Y104 {
		get => this[Addresses.Y104];
		set => this[Addresses.Y104] = value;
	}


	/// <summary>
	/// +Y104+Y15
	/// </summary>
	public object Y105 {
		get => this[Addresses.Y105];
		set => this[Addresses.Y105] = value;
	}


	/// <summary>
	/// +Y105+Y15
	/// </summary>
	public object Y106 {
		get => this[Addresses.Y106];
		set => this[Addresses.Y106] = value;
	}


	/// <summary>
	/// +Y106+Y15
	/// </summary>
	public object Y107 {
		get => this[Addresses.Y107];
		set => this[Addresses.Y107] = value;
	}


	/// <summary>
	/// +Y107+Y15
	/// </summary>
	public object Y108 {
		get => this[Addresses.Y108];
		set => this[Addresses.Y108] = value;
	}


	/// <summary>
	/// +Y108+Y15
	/// </summary>
	public object Y109 {
		get => this[Addresses.Y109];
		set => this[Addresses.Y109] = value;
	}


	/// <summary>
	/// +Y109+Y15
	/// </summary>
	public object Y110 {
		get => this[Addresses.Y110];
		set => this[Addresses.Y110] = value;
	}


	/// <summary>
	/// +Y110+Y15
	/// </summary>
	public object Y111 {
		get => this[Addresses.Y111];
		set => this[Addresses.Y111] = value;
	}


	/// <summary>
	/// +Y111+Y15
	/// </summary>
	public object Y112 {
		get => this[Addresses.Y112];
		set => this[Addresses.Y112] = value;
	}


	/// <summary>
	/// IF(Y112<=B29,1,"")
	/// </summary>
	public object AI112 {
		get => this[Addresses.AI112];
		set => this[Addresses.AI112] = value;
	}


	/// <summary>
	/// IF(SUM(AI20:AI112)=0,1,0)
	/// </summary>
	public object AK11 {
		get => this[Addresses.AK11];
		set => this[Addresses.AK11] = value;
	}


	/// <summary>
	/// IF(AI112<>1,AB17,B30+0.5)
	/// </summary>
	public object Z112 {
		get => this[Addresses.Z112];
		set => this[Addresses.Z112] = value;
	}


	/// <summary>
	/// +SQRT(((X7-X112)^2)+((Y112-Y7)^2)+((Z112-Z7)^2))
	/// </summary>
	public object AE112 {
		get => this[Addresses.AE112];
		set => this[Addresses.AE112] = value;
	}


	/// <summary>
	/// +AB12-(20*LOG10(AE112))-9
	/// </summary>
	public object AF112 {
		get => this[Addresses.AF112];
		set => this[Addresses.AF112] = value;
	}


	/// <summary>
	/// (((X112-AJ112)^2)+((Y112-AK112)^2)+((Z112-Z7)^2))^0.5
	/// </summary>
	public object AN112 {
		get => this[Addresses.AN112];
		set => this[Addresses.AN112] = value;
	}


	/// <summary>
	/// (((X112-AX112)^2)+((Y112-AY112)^2)+((Z112-Z7)^2))^0.5
	/// </summary>
	public object BB112 {
		get => this[Addresses.BB112];
		set => this[Addresses.BB112] = value;
	}


	/// <summary>
	/// +SQRT(((X7-X112)^2)+((Y112+Y7)^2)+((Z112-Z7)^2))
	/// </summary>
	public object BE112 {
		get => this[Addresses.BE112];
		set => this[Addresses.BE112] = value;
	}


	/// <summary>
	/// Y7+(AL112*(Y112-Y7))
	/// </summary>
	public object AM112 {
		get => this[Addresses.AM112];
		set => this[Addresses.AM112] = value;
	}


	/// <summary>
	/// IF(AM112<=B27,1,0)
	/// </summary>
	public object AO112 {
		get => this[Addresses.AO112];
		set => this[Addresses.AO112] = value;
	}


	/// <summary>
	/// IF((AO112=1),(AB12-(20*LOG10(AN112))-9+(10*LOG10(1-B59))),-9999)
	/// </summary>
	public object AP112 {
		get => this[Addresses.AP112];
		set => this[Addresses.AP112] = value;
	}


	/// <summary>
	/// X7+(Y7*(X112-X7)/(Y112+Y7))
	/// </summary>
	public object AG112 {
		get => this[Addresses.AG112];
		set => this[Addresses.AG112] = value;
	}


	/// <summary>
	/// IF(AG112>=X10,IF(AG112<=Y10,1,""),"")
	/// </summary>
	public object AH112 {
		get => this[Addresses.AH112];
		set => this[Addresses.AH112] = value;
	}


	/// <summary>
	/// IF((B58<1),IF((AH112=1),+AB12-(20*LOG10(BE112))-9+(10*LOG10(1-B58)),-999),-999)
	/// </summary>
	public object BF112 {
		get => this[Addresses.BF112];
		set => this[Addresses.BF112] = value;
	}


	/// <summary>
	/// (-B21+Y7)/(2*B21-Y7-Y112)
	/// </summary>
	public object AZ112 {
		get => this[Addresses.AZ112];
		set => this[Addresses.AZ112] = value;
	}


	/// <summary>
	/// X7+(AZ112*(X7-X112))
	/// </summary>
	public object BA112 {
		get => this[Addresses.BA112];
		set => this[Addresses.BA112] = value;
	}


	/// <summary>
	/// IF(AND(BA112>B31,BA112<B32),1,0)
	/// </summary>
	public object BC112 {
		get => this[Addresses.BC112];
		set => this[Addresses.BC112] = value;
	}


	/// <summary>
	/// IF(BC112=1,AB12-(20*LOG10(BB112))-9+(10*LOG10(1-B59)),-9999)
	/// </summary>
	public object BD112 {
		get => this[Addresses.BD112];
		set => this[Addresses.BD112] = value;
	}


	/// <summary>
	/// 10*LOG10((10^(AP112/10))+(10^(AW112/10))+(10^(BD112/10))+(10^(BF112/10)))
	/// </summary>
	public object BG112 {
		get => this[Addresses.BG112];
		set => this[Addresses.BG112] = value;
	}


	/// <summary>
	/// IF((L112=1),IF((AI112=1),ROUND(10*LOG10((10^(AF112/10))+(10^(BG112/10))),0),""),"")
	/// </summary>
	public object BJ112 {
		get => this[Addresses.BJ112];
		set => this[Addresses.BJ112] = value;
	}


	/// <summary>
	/// MAX(BJ20:BJ112)
	/// </summary>
	public object BJ17 {
		get => this[Addresses.BJ17];
		set => this[Addresses.BJ17] = value;
	}


	/// <summary>
	/// IF(AK11=0,MAX(BJ20:BJ112),"")
	/// </summary>
	public object C66 {
		get => this[Addresses.C66];
		set => this[Addresses.C66] = value;
	}


	/// <summary>
	/// IF(BJ17<>0,C66-C67,"")
	/// </summary>
	public object C68 {
		get => this[Addresses.C68];
		set => this[Addresses.C68] = value;
	}


	/// <summary>
	/// IF(BJ17<>0,B15-C68,"")
	/// </summary>
	public object C69 {
		get => this[Addresses.C69];
		set => this[Addresses.C69] = value;
	}


	/// <summary>
	/// IF(BJ17<>0,ROUND(45+C69,0),"")
	/// </summary>
	public object G50 {
		get => this[Addresses.G50];
		set => this[Addresses.G50] = value;
	}


	/// <summary>
	/// IF(G50<>"",-G50,-9999)
	/// </summary>
	public object G52 {
		get => this[Addresses.G52];
		set => this[Addresses.G52] = value;
	}


	/// <summary>
	/// (-MAX(C52:G52))-B16
	/// </summary>
	public object C54 {
		get => this[Addresses.C54];
		set => this[Addresses.C54] = value;
	}


	/// <summary>
	/// ROUND(C54,0)
	/// </summary>
	public object C74 {
		get => this[Addresses.C74];
		set => this[Addresses.C74] = value;
	}


	/// <summary>
	/// IF((C88<=C74),"VOLDOET","VOLDOET NIET")
	/// </summary>
	public object B89 {
		get => this[Addresses.B89];
		set => this[Addresses.B89] = value;
	}


	/// <summary>
	/// C54-5
	/// </summary>
	public object C55 {
		get => this[Addresses.C55];
		set => this[Addresses.C55] = value;
	}


	/// <summary>
	/// ROUND(C55,0)
	/// </summary>
	public object F74 {
		get => this[Addresses.F74];
		set => this[Addresses.F74] = value;
	}


	/// <summary>
	/// IF((F88<=F74),"VOLDOET","VOLDOET NIET")
	/// </summary>
	public object E89 {
		get => this[Addresses.E89];
		set => this[Addresses.E89] = value;
	}

	
	protected override IEnumerable<KeyValuePair<string, Func<object>>> GetFormulas()
	{
		yield return new KeyValuePair<string, Func<object>>("C88", () => Subtract(Add(C85, C86), C87));
		yield return new KeyValuePair<string, Func<object>>("F88", () => Subtract(Add(F85, F86), F87));
		yield return new KeyValuePair<string, Func<object>>("C61", () => SQRT(Add(Add((Pow((Subtract(B11, C35)), 2)), (Pow((Subtract(B12, C36)), 2))), (Pow((Subtract(B13, C37)), 2)))));
		yield return new KeyValuePair<string, Func<object>>("C62", () => IF((object.Equals(C38, "J")), 5, 0));
		yield return new KeyValuePair<string, Func<object>>("C63", () => Multiply(10, LOG10(Divide(2, C39))));
		yield return new KeyValuePair<string, Func<object>>("C64", () => Subtract(Add(Add(Multiply(20, LOG10(C61)), 9), C62), C63));
		yield return new KeyValuePair<string, Func<object>>("C50", () => IF(object.Equals(C35, "nvt"), "", ROUND(Add(45, C64), 0)));
		yield return new KeyValuePair<string, Func<object>>("C52", () => IF(!object.Equals(C50, ""), Negate(C50), Negate(9999)));
		yield return new KeyValuePair<string, Func<object>>("L20", () => IF(object.Equals(I21, "j"), 1, 0));
		yield return new KeyValuePair<string, Func<object>>("AB12", () => B15);
		yield return new KeyValuePair<string, Func<object>>("L112", () => IF(object.Equals(I19, "j"), 1, 0));
		yield return new KeyValuePair<string, Func<object>>("X7", () => B11);
		yield return new KeyValuePair<string, Func<object>>("Y7", () => B12);
		yield return new KeyValuePair<string, Func<object>>("Z7", () => B13);
		yield return new KeyValuePair<string, Func<object>>("BD20", () => IF(object.Equals(BC20, 1), Add(Subtract(Subtract(AB12, (Multiply(20, LOG10(BB20)))), 9), (Multiply(10, LOG10(Subtract(1, B59))))), Negate(9999)));
		yield return new KeyValuePair<string, Func<object>>("AW112", () => IF(object.Equals(AV112, 1), Add(Subtract(Subtract(AB12, (Multiply(20, LOG10(AU112)))), 9), (Multiply(10, LOG10(Subtract(1, B59))))), Negate(9999)));
		yield return new KeyValuePair<string, Func<object>>("Z17", () => Plus(MIN(B20, B21)));
		yield return new KeyValuePair<string, Func<object>>("X20", () => Plus(Z17));
		yield return new KeyValuePair<string, Func<object>>("AI20", () => IF(Greater(X20, B31), IF(Less(X20, B32), 1, ""), ""));
		yield return new KeyValuePair<string, Func<object>>("AA17", () => Plus(MAX(B20, B21)));
		yield return new KeyValuePair<string, Func<object>>("Y20", () => Plus(AA17));
		yield return new KeyValuePair<string, Func<object>>("Y15", () => Divide(Plus((Subtract(AA17, Z17))), 30));
		yield return new KeyValuePair<string, Func<object>>("AJ20", () => Negate(X7));
		yield return new KeyValuePair<string, Func<object>>("AK20", () => Y7);
		yield return new KeyValuePair<string, Func<object>>("AR20", () => Y7);
		yield return new KeyValuePair<string, Func<object>>("AG20", () => Add(X7, (Divide(Multiply(Y7, (Subtract(X20, X7))), (Add(Y20, Y7))))));
		yield return new KeyValuePair<string, Func<object>>("AJ112", () => Negate(X7));
		yield return new KeyValuePair<string, Func<object>>("AK112", () => Y7);
		yield return new KeyValuePair<string, Func<object>>("AX112", () => X7);
		yield return new KeyValuePair<string, Func<object>>("AY112", () => Subtract(Multiply(2, B21), Y7));
		yield return new KeyValuePair<string, Func<object>>("AB17", () => Plus(B22));
		yield return new KeyValuePair<string, Func<object>>("Z20", () => IF(!object.Equals(AI20, 1), AB17, Add(B33, 0.5)));
		yield return new KeyValuePair<string, Func<object>>("AE20", () => Plus(SQRT(Add(Add((Pow((Subtract(X7, X20)), 2)), (Pow((Subtract(Y20, Y7)), 2))), (Pow((Subtract(Z20, Z7)), 2))))));
		yield return new KeyValuePair<string, Func<object>>("AF20", () => Subtract(Subtract(Plus(AB12), (Multiply(20, LOG10(AE20)))), 9));
		yield return new KeyValuePair<string, Func<object>>("AN20", () => Pow((Add(Add((Pow((Subtract(X20, AJ20)), 2)), (Pow((Subtract(Y20, AK20)), 2))), (Pow((Subtract(Z20, Z7)), 2)))), 0.5));
		yield return new KeyValuePair<string, Func<object>>("BE20", () => Plus(SQRT(Add(Add((Pow((Subtract(X7, X20)), 2)), (Pow((Add(Y20, Y7)), 2))), (Pow((Subtract(Z20, Z7)), 2))))));
		yield return new KeyValuePair<string, Func<object>>("AL20", () => Divide(X7, (Add(X20, X7))));
		yield return new KeyValuePair<string, Func<object>>("AM20", () => Add(Y7, (Multiply(AL20, (Subtract(Y20, Y7))))));
		yield return new KeyValuePair<string, Func<object>>("AO20", () => IF((LessOrEqual(AM20, B27)), 1, 0));
		yield return new KeyValuePair<string, Func<object>>("AP20", () => IF((object.Equals(AO20, 1)), (Add(Subtract(Subtract(AB12, (Multiply(20, LOG10(AN20)))), 9), (Multiply(10, LOG10(Subtract(1, B59)))))), Negate(9999)));
		yield return new KeyValuePair<string, Func<object>>("AQ20", () => Subtract(Multiply(2, B19), B11));
		yield return new KeyValuePair<string, Func<object>>("AU20", () => Pow((Add(Add((Pow((Subtract(AQ20, X20)), 2)), (Pow((Subtract(AR20, Y20)), 2))), (Pow((Subtract(Z20, Z7)), 2)))), 0.5));
		yield return new KeyValuePair<string, Func<object>>("AS20", () => Divide((Add(Negate(B19), X7)), (Subtract(Subtract(Multiply(2, B19), X7), X20))));
		yield return new KeyValuePair<string, Func<object>>("AT20", () => Add(Y7, (Multiply(AS20, (Subtract(Y7, Y20))))));
		yield return new KeyValuePair<string, Func<object>>("AV20", () => IF(Less(AT20, B29), 1, 0));
		yield return new KeyValuePair<string, Func<object>>("AW20", () => IF(object.Equals(AV20, 1), Add(Subtract(Subtract(AB12, (Multiply(20, LOG10(AU20)))), 9), (Multiply(10, LOG10(Subtract(1, B59))))), Negate(9999)));
		yield return new KeyValuePair<string, Func<object>>("X10", () => B24);
		yield return new KeyValuePair<string, Func<object>>("Y10", () => B25);
		yield return new KeyValuePair<string, Func<object>>("AH20", () => IF(GreaterOrEqual(AG20, X10), IF(LessOrEqual(AG20, Y10), 1, ""), ""));
		yield return new KeyValuePair<string, Func<object>>("BF20", () => IF((Less(B58, 1)), IF((object.Equals(AH20, 1)), Add(Subtract(Subtract(Plus(AB12), (Multiply(20, LOG10(BE20)))), 9), (Multiply(10, LOG10(Subtract(1, B58))))), Negate(999)), Negate(999)));
		yield return new KeyValuePair<string, Func<object>>("BG20", () => Multiply(10, LOG10(Add(Add(Add((Pow(10, (Divide(AP20, 10)))), (Pow(10, (Divide(AW20, 10))))), (Pow(10, (Divide(BD20, 10))))), (Pow(10, (Divide(BF20, 10))))))));
		yield return new KeyValuePair<string, Func<object>>("BJ20", () => IF((object.Equals(L20, 1)), IF((object.Equals(AI20, 1)), ROUND(Multiply(10, LOG10(Add((Pow(10, (Divide(AF20, 10)))), (Pow(10, (Divide(BG20, 10))))))), 0), ""), ""));
		yield return new KeyValuePair<string, Func<object>>("Y17", () => Plus(MAX(B18, B19)));
		yield return new KeyValuePair<string, Func<object>>("X112", () => Plus(Y17));
		yield return new KeyValuePair<string, Func<object>>("AL112", () => Divide(X7, (Add(X112, X7))));
		yield return new KeyValuePair<string, Func<object>>("Y51", () => Plus(Z17));
		yield return new KeyValuePair<string, Func<object>>("Y82", () => Plus(Y51));
		yield return new KeyValuePair<string, Func<object>>("Y83", () => Add(Plus(Y82), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y84", () => Add(Plus(Y83), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y85", () => Add(Plus(Y84), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y86", () => Add(Plus(Y85), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y87", () => Add(Plus(Y86), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y88", () => Add(Plus(Y87), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y89", () => Add(Plus(Y88), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y90", () => Add(Plus(Y89), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y91", () => Add(Plus(Y90), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y92", () => Add(Plus(Y91), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y93", () => Add(Plus(Y92), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y94", () => Add(Plus(Y93), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y95", () => Add(Plus(Y94), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y96", () => Add(Plus(Y95), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y97", () => Add(Plus(Y96), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y98", () => Add(Plus(Y97), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y99", () => Add(Plus(Y98), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y100", () => Add(Plus(Y99), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y101", () => Add(Plus(Y100), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y102", () => Add(Plus(Y101), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y103", () => Add(Plus(Y102), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y104", () => Add(Plus(Y103), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y105", () => Add(Plus(Y104), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y106", () => Add(Plus(Y105), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y107", () => Add(Plus(Y106), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y108", () => Add(Plus(Y107), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y109", () => Add(Plus(Y108), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y110", () => Add(Plus(Y109), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y111", () => Add(Plus(Y110), Y15));
		yield return new KeyValuePair<string, Func<object>>("Y112", () => Add(Plus(Y111), Y15));
		yield return new KeyValuePair<string, Func<object>>("AI112", () => IF(LessOrEqual(Y112, B29), 1, ""));
		yield return new KeyValuePair<string, Func<object>>("AK11", () => IF(object.Equals(SUM(new CellRange(Addresses.AI20, Addresses.AI112)), 0), 1, 0));
		yield return new KeyValuePair<string, Func<object>>("Z112", () => IF(!object.Equals(AI112, 1), AB17, Add(B30, 0.5)));
		yield return new KeyValuePair<string, Func<object>>("AE112", () => Plus(SQRT(Add(Add((Pow((Subtract(X7, X112)), 2)), (Pow((Subtract(Y112, Y7)), 2))), (Pow((Subtract(Z112, Z7)), 2))))));
		yield return new KeyValuePair<string, Func<object>>("AF112", () => Subtract(Subtract(Plus(AB12), (Multiply(20, LOG10(AE112)))), 9));
		yield return new KeyValuePair<string, Func<object>>("AN112", () => Pow((Add(Add((Pow((Subtract(X112, AJ112)), 2)), (Pow((Subtract(Y112, AK112)), 2))), (Pow((Subtract(Z112, Z7)), 2)))), 0.5));
		yield return new KeyValuePair<string, Func<object>>("BB112", () => Pow((Add(Add((Pow((Subtract(X112, AX112)), 2)), (Pow((Subtract(Y112, AY112)), 2))), (Pow((Subtract(Z112, Z7)), 2)))), 0.5));
		yield return new KeyValuePair<string, Func<object>>("BE112", () => Plus(SQRT(Add(Add((Pow((Subtract(X7, X112)), 2)), (Pow((Add(Y112, Y7)), 2))), (Pow((Subtract(Z112, Z7)), 2))))));
		yield return new KeyValuePair<string, Func<object>>("AM112", () => Add(Y7, (Multiply(AL112, (Subtract(Y112, Y7))))));
		yield return new KeyValuePair<string, Func<object>>("AO112", () => IF(LessOrEqual(AM112, B27), 1, 0));
		yield return new KeyValuePair<string, Func<object>>("AP112", () => IF((object.Equals(AO112, 1)), (Add(Subtract(Subtract(AB12, (Multiply(20, LOG10(AN112)))), 9), (Multiply(10, LOG10(Subtract(1, B59)))))), Negate(9999)));
		yield return new KeyValuePair<string, Func<object>>("AG112", () => Add(X7, (Divide(Multiply(Y7, (Subtract(X112, X7))), (Add(Y112, Y7))))));
		yield return new KeyValuePair<string, Func<object>>("AH112", () => IF(GreaterOrEqual(AG112, X10), IF(LessOrEqual(AG112, Y10), 1, ""), ""));
		yield return new KeyValuePair<string, Func<object>>("BF112", () => IF((Less(B58, 1)), IF((object.Equals(AH112, 1)), Add(Subtract(Subtract(Plus(AB12), (Multiply(20, LOG10(BE112)))), 9), (Multiply(10, LOG10(Subtract(1, B58))))), Negate(999)), Negate(999)));
		yield return new KeyValuePair<string, Func<object>>("AZ112", () => Divide((Add(Negate(B21), Y7)), (Subtract(Subtract(Multiply(2, B21), Y7), Y112))));
		yield return new KeyValuePair<string, Func<object>>("BA112", () => Add(X7, (Multiply(AZ112, (Subtract(X7, X112))))));
		yield return new KeyValuePair<string, Func<object>>("BC112", () => IF(AND(Greater(BA112, B31), Less(BA112, B32)), 1, 0));
		yield return new KeyValuePair<string, Func<object>>("BD112", () => IF(object.Equals(BC112, 1), Add(Subtract(Subtract(AB12, (Multiply(20, LOG10(BB112)))), 9), (Multiply(10, LOG10(Subtract(1, B59))))), Negate(9999)));
		yield return new KeyValuePair<string, Func<object>>("BG112", () => Multiply(10, LOG10(Add(Add(Add((Pow(10, (Divide(AP112, 10)))), (Pow(10, (Divide(AW112, 10))))), (Pow(10, (Divide(BD112, 10))))), (Pow(10, (Divide(BF112, 10))))))));
		yield return new KeyValuePair<string, Func<object>>("BJ112", () => IF((object.Equals(L112, 1)), IF((object.Equals(AI112, 1)), ROUND(Multiply(10, LOG10(Add((Pow(10, (Divide(AF112, 10)))), (Pow(10, (Divide(BG112, 10))))))), 0), ""), ""));
		yield return new KeyValuePair<string, Func<object>>("BJ17", () => MAX(new CellRange(Addresses.BJ20, Addresses.BJ112)));
		yield return new KeyValuePair<string, Func<object>>("C66", () => IF(object.Equals(AK11, 0), MAX(new CellRange(Addresses.BJ20, Addresses.BJ112)), ""));
		yield return new KeyValuePair<string, Func<object>>("C68", () => IF(!object.Equals(BJ17, 0), Subtract(C66, C67), ""));
		yield return new KeyValuePair<string, Func<object>>("C69", () => IF(!object.Equals(BJ17, 0), Subtract(B15, C68), ""));
		yield return new KeyValuePair<string, Func<object>>("G50", () => IF(!object.Equals(BJ17, 0), ROUND(Add(45, C69), 0), ""));
		yield return new KeyValuePair<string, Func<object>>("G52", () => IF(!object.Equals(G50, ""), Negate(G50), Negate(9999)));
		yield return new KeyValuePair<string, Func<object>>("C54", () => Subtract((Negate(MAX(new CellRange(Addresses.C52, Addresses.G52)))), B16));
		yield return new KeyValuePair<string, Func<object>>("C74", () => ROUND(C54, 0));
		yield return new KeyValuePair<string, Func<object>>("B89", () => IF((LessOrEqual(C88, C74)), "VOLDOET", "VOLDOET NIET"));
		yield return new KeyValuePair<string, Func<object>>("C55", () => Subtract(C54, 5));
		yield return new KeyValuePair<string, Func<object>>("F74", () => ROUND(C55, 0));
		yield return new KeyValuePair<string, Func<object>>("E89", () => IF((LessOrEqual(F88, F74)), "VOLDOET", "VOLDOET NIET"));
	}
	
	public static class Addresses
	{
		public static readonly CellRef AA17 = CellRef.Parse("AA17");
		public static readonly CellRef AB12 = CellRef.Parse("AB12");
		public static readonly CellRef AB17 = CellRef.Parse("AB17");
		public static readonly CellRef AE112 = CellRef.Parse("AE112");
		public static readonly CellRef AE20 = CellRef.Parse("AE20");
		public static readonly CellRef AF112 = CellRef.Parse("AF112");
		public static readonly CellRef AF20 = CellRef.Parse("AF20");
		public static readonly CellRef AG112 = CellRef.Parse("AG112");
		public static readonly CellRef AG20 = CellRef.Parse("AG20");
		public static readonly CellRef AH112 = CellRef.Parse("AH112");
		public static readonly CellRef AH20 = CellRef.Parse("AH20");
		public static readonly CellRef AI112 = CellRef.Parse("AI112");
		public static readonly CellRef AI20 = CellRef.Parse("AI20");
		public static readonly CellRef AJ112 = CellRef.Parse("AJ112");
		public static readonly CellRef AJ20 = CellRef.Parse("AJ20");
		public static readonly CellRef AK11 = CellRef.Parse("AK11");
		public static readonly CellRef AK112 = CellRef.Parse("AK112");
		public static readonly CellRef AK20 = CellRef.Parse("AK20");
		public static readonly CellRef AL112 = CellRef.Parse("AL112");
		public static readonly CellRef AL20 = CellRef.Parse("AL20");
		public static readonly CellRef AM112 = CellRef.Parse("AM112");
		public static readonly CellRef AM20 = CellRef.Parse("AM20");
		public static readonly CellRef AN112 = CellRef.Parse("AN112");
		public static readonly CellRef AN20 = CellRef.Parse("AN20");
		public static readonly CellRef AO112 = CellRef.Parse("AO112");
		public static readonly CellRef AO20 = CellRef.Parse("AO20");
		public static readonly CellRef AP112 = CellRef.Parse("AP112");
		public static readonly CellRef AP20 = CellRef.Parse("AP20");
		public static readonly CellRef AQ20 = CellRef.Parse("AQ20");
		public static readonly CellRef AR20 = CellRef.Parse("AR20");
		public static readonly CellRef AS20 = CellRef.Parse("AS20");
		public static readonly CellRef AT20 = CellRef.Parse("AT20");
		public static readonly CellRef AU112 = CellRef.Parse("AU112");
		public static readonly CellRef AU20 = CellRef.Parse("AU20");
		public static readonly CellRef AV112 = CellRef.Parse("AV112");
		public static readonly CellRef AV20 = CellRef.Parse("AV20");
		public static readonly CellRef AW112 = CellRef.Parse("AW112");
		public static readonly CellRef AW20 = CellRef.Parse("AW20");
		public static readonly CellRef AX112 = CellRef.Parse("AX112");
		public static readonly CellRef AY112 = CellRef.Parse("AY112");
		public static readonly CellRef AZ112 = CellRef.Parse("AZ112");
		public static readonly CellRef B11 = CellRef.Parse("B11");
		public static readonly CellRef B12 = CellRef.Parse("B12");
		public static readonly CellRef B13 = CellRef.Parse("B13");
		public static readonly CellRef B15 = CellRef.Parse("B15");
		public static readonly CellRef B16 = CellRef.Parse("B16");
		public static readonly CellRef B18 = CellRef.Parse("B18");
		public static readonly CellRef B19 = CellRef.Parse("B19");
		public static readonly CellRef B20 = CellRef.Parse("B20");
		public static readonly CellRef B21 = CellRef.Parse("B21");
		public static readonly CellRef B22 = CellRef.Parse("B22");
		public static readonly CellRef B24 = CellRef.Parse("B24");
		public static readonly CellRef B25 = CellRef.Parse("B25");
		public static readonly CellRef B27 = CellRef.Parse("B27");
		public static readonly CellRef B29 = CellRef.Parse("B29");
		public static readonly CellRef B30 = CellRef.Parse("B30");
		public static readonly CellRef B31 = CellRef.Parse("B31");
		public static readonly CellRef B32 = CellRef.Parse("B32");
		public static readonly CellRef B33 = CellRef.Parse("B33");
		public static readonly CellRef B58 = CellRef.Parse("B58");
		public static readonly CellRef B59 = CellRef.Parse("B59");
		public static readonly CellRef B89 = CellRef.Parse("B89");
		public static readonly CellRef BA112 = CellRef.Parse("BA112");
		public static readonly CellRef BB112 = CellRef.Parse("BB112");
		public static readonly CellRef BB20 = CellRef.Parse("BB20");
		public static readonly CellRef BC112 = CellRef.Parse("BC112");
		public static readonly CellRef BC20 = CellRef.Parse("BC20");
		public static readonly CellRef BD112 = CellRef.Parse("BD112");
		public static readonly CellRef BD20 = CellRef.Parse("BD20");
		public static readonly CellRef BE112 = CellRef.Parse("BE112");
		public static readonly CellRef BE20 = CellRef.Parse("BE20");
		public static readonly CellRef BF112 = CellRef.Parse("BF112");
		public static readonly CellRef BF20 = CellRef.Parse("BF20");
		public static readonly CellRef BG112 = CellRef.Parse("BG112");
		public static readonly CellRef BG20 = CellRef.Parse("BG20");
		public static readonly CellRef BJ112 = CellRef.Parse("BJ112");
		public static readonly CellRef BJ17 = CellRef.Parse("BJ17");
		public static readonly CellRef BJ20 = CellRef.Parse("BJ20");
		public static readonly CellRef C35 = CellRef.Parse("C35");
		public static readonly CellRef C36 = CellRef.Parse("C36");
		public static readonly CellRef C37 = CellRef.Parse("C37");
		public static readonly CellRef C38 = CellRef.Parse("C38");
		public static readonly CellRef C39 = CellRef.Parse("C39");
		public static readonly CellRef C50 = CellRef.Parse("C50");
		public static readonly CellRef C52 = CellRef.Parse("C52");
		public static readonly CellRef C54 = CellRef.Parse("C54");
		public static readonly CellRef C55 = CellRef.Parse("C55");
		public static readonly CellRef C61 = CellRef.Parse("C61");
		public static readonly CellRef C62 = CellRef.Parse("C62");
		public static readonly CellRef C63 = CellRef.Parse("C63");
		public static readonly CellRef C64 = CellRef.Parse("C64");
		public static readonly CellRef C66 = CellRef.Parse("C66");
		public static readonly CellRef C67 = CellRef.Parse("C67");
		public static readonly CellRef C68 = CellRef.Parse("C68");
		public static readonly CellRef C69 = CellRef.Parse("C69");
		public static readonly CellRef C74 = CellRef.Parse("C74");
		public static readonly CellRef C85 = CellRef.Parse("C85");
		public static readonly CellRef C86 = CellRef.Parse("C86");
		public static readonly CellRef C87 = CellRef.Parse("C87");
		public static readonly CellRef C88 = CellRef.Parse("C88");
		public static readonly CellRef E89 = CellRef.Parse("E89");
		public static readonly CellRef F74 = CellRef.Parse("F74");
		public static readonly CellRef F85 = CellRef.Parse("F85");
		public static readonly CellRef F86 = CellRef.Parse("F86");
		public static readonly CellRef F87 = CellRef.Parse("F87");
		public static readonly CellRef F88 = CellRef.Parse("F88");
		public static readonly CellRef G50 = CellRef.Parse("G50");
		public static readonly CellRef G52 = CellRef.Parse("G52");
		public static readonly CellRef I19 = CellRef.Parse("I19");
		public static readonly CellRef I21 = CellRef.Parse("I21");
		public static readonly CellRef L112 = CellRef.Parse("L112");
		public static readonly CellRef L20 = CellRef.Parse("L20");
		public static readonly CellRef X10 = CellRef.Parse("X10");
		public static readonly CellRef X112 = CellRef.Parse("X112");
		public static readonly CellRef X20 = CellRef.Parse("X20");
		public static readonly CellRef X7 = CellRef.Parse("X7");
		public static readonly CellRef Y10 = CellRef.Parse("Y10");
		public static readonly CellRef Y100 = CellRef.Parse("Y100");
		public static readonly CellRef Y101 = CellRef.Parse("Y101");
		public static readonly CellRef Y102 = CellRef.Parse("Y102");
		public static readonly CellRef Y103 = CellRef.Parse("Y103");
		public static readonly CellRef Y104 = CellRef.Parse("Y104");
		public static readonly CellRef Y105 = CellRef.Parse("Y105");
		public static readonly CellRef Y106 = CellRef.Parse("Y106");
		public static readonly CellRef Y107 = CellRef.Parse("Y107");
		public static readonly CellRef Y108 = CellRef.Parse("Y108");
		public static readonly CellRef Y109 = CellRef.Parse("Y109");
		public static readonly CellRef Y110 = CellRef.Parse("Y110");
		public static readonly CellRef Y111 = CellRef.Parse("Y111");
		public static readonly CellRef Y112 = CellRef.Parse("Y112");
		public static readonly CellRef Y15 = CellRef.Parse("Y15");
		public static readonly CellRef Y17 = CellRef.Parse("Y17");
		public static readonly CellRef Y20 = CellRef.Parse("Y20");
		public static readonly CellRef Y51 = CellRef.Parse("Y51");
		public static readonly CellRef Y7 = CellRef.Parse("Y7");
		public static readonly CellRef Y82 = CellRef.Parse("Y82");
		public static readonly CellRef Y83 = CellRef.Parse("Y83");
		public static readonly CellRef Y84 = CellRef.Parse("Y84");
		public static readonly CellRef Y85 = CellRef.Parse("Y85");
		public static readonly CellRef Y86 = CellRef.Parse("Y86");
		public static readonly CellRef Y87 = CellRef.Parse("Y87");
		public static readonly CellRef Y88 = CellRef.Parse("Y88");
		public static readonly CellRef Y89 = CellRef.Parse("Y89");
		public static readonly CellRef Y90 = CellRef.Parse("Y90");
		public static readonly CellRef Y91 = CellRef.Parse("Y91");
		public static readonly CellRef Y92 = CellRef.Parse("Y92");
		public static readonly CellRef Y93 = CellRef.Parse("Y93");
		public static readonly CellRef Y94 = CellRef.Parse("Y94");
		public static readonly CellRef Y95 = CellRef.Parse("Y95");
		public static readonly CellRef Y96 = CellRef.Parse("Y96");
		public static readonly CellRef Y97 = CellRef.Parse("Y97");
		public static readonly CellRef Y98 = CellRef.Parse("Y98");
		public static readonly CellRef Y99 = CellRef.Parse("Y99");
		public static readonly CellRef Z112 = CellRef.Parse("Z112");
		public static readonly CellRef Z17 = CellRef.Parse("Z17");
		public static readonly CellRef Z20 = CellRef.Parse("Z20");
		public static readonly CellRef Z7 = CellRef.Parse("Z7");
	}
}
