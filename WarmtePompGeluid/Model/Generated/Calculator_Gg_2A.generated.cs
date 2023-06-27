using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Ambacht.Common.Excel;

namespace WarmtePompGeluid.Model.Generated;

public class Calculator_Gg_2A : ExcelCalculatorBase {

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
	public object C33 {
		get => this[Addresses.C33];
		set => this[Addresses.C33] = value;
	}


	/// <summary>
	/// variable (Blank)
	/// </summary>
	public object F33 {
		get => this[Addresses.F33];
		set => this[Addresses.F33] = value;
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
	public object C34 {
		get => this[Addresses.C34];
		set => this[Addresses.C34] = value;
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
	public object C35 {
		get => this[Addresses.C35];
		set => this[Addresses.C35] = value;
	}


	/// <summary>
	/// SQRT(((B11-C33)^2)+((B12-C34)^2)+((B13-C35)^2))
	/// </summary>
	public object C56 {
		get => this[Addresses.C56];
		set => this[Addresses.C56] = value;
	}


	/// <summary>
	/// variable (String)
	/// </summary>
	public object C36 {
		get => this[Addresses.C36];
		set => this[Addresses.C36] = value;
	}


	/// <summary>
	/// IF(C36="J",5,0)
	/// </summary>
	public object C57 {
		get => this[Addresses.C57];
		set => this[Addresses.C57] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object C37 {
		get => this[Addresses.C37];
		set => this[Addresses.C37] = value;
	}


	/// <summary>
	/// 10*LOG10(2/C37)
	/// </summary>
	public object C58 {
		get => this[Addresses.C58];
		set => this[Addresses.C58] = value;
	}


	/// <summary>
	/// IF(C33="nvt",9999,(20*LOG10(C56)+9+C57-C58))
	/// </summary>
	public object C59 {
		get => this[Addresses.C59];
		set => this[Addresses.C59] = value;
	}


	/// <summary>
	/// IF(C33<>"nvt",ROUND(45+C59,0),"")
	/// </summary>
	public object C65 {
		get => this[Addresses.C65];
		set => this[Addresses.C65] = value;
	}


	/// <summary>
	/// IF(C65<>"",-C65,-9999)
	/// </summary>
	public object C68 {
		get => this[Addresses.C68];
		set => this[Addresses.C68] = value;
	}


	/// <summary>
	/// variable (Blank)
	/// </summary>
	public object CV18 {
		get => this[Addresses.CV18];
		set => this[Addresses.CV18] = value;
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
	public object L141 {
		get => this[Addresses.L141];
		set => this[Addresses.L141] = value;
	}


	/// <summary>
	/// B15
	/// </summary>
	public object AC10 {
		get => this[Addresses.AC10];
		set => this[Addresses.AC10] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B50 {
		get => this[Addresses.B50];
		set => this[Addresses.B50] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B28 {
		get => this[Addresses.B28];
		set => this[Addresses.B28] = value;
	}


	/// <summary>
	/// B28
	/// </summary>
	public object Y8 {
		get => this[Addresses.Y8];
		set => this[Addresses.Y8] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B18 {
		get => this[Addresses.B18];
		set => this[Addresses.B18] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B19 {
		get => this[Addresses.B19];
		set => this[Addresses.B19] = value;
	}


	/// <summary>
	/// +MAX(B18,B19)
	/// </summary>
	public object Y15 {
		get => this[Addresses.Y15];
		set => this[Addresses.Y15] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B30 {
		get => this[Addresses.B30];
		set => this[Addresses.B30] = value;
	}


	/// <summary>
	/// +B30
	/// </summary>
	public object AB8 {
		get => this[Addresses.AB8];
		set => this[Addresses.AB8] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B29 {
		get => this[Addresses.B29];
		set => this[Addresses.B29] = value;
	}


	/// <summary>
	/// B29
	/// </summary>
	public object Z8 {
		get => this[Addresses.Z8];
		set => this[Addresses.Z8] = value;
	}


	/// <summary>
	/// B11
	/// </summary>
	public object X6 {
		get => this[Addresses.X6];
		set => this[Addresses.X6] = value;
	}


	/// <summary>
	/// +Y15
	/// </summary>
	public object X141 {
		get => this[Addresses.X141];
		set => this[Addresses.X141] = value;
	}


	/// <summary>
	/// B12
	/// </summary>
	public object Y6 {
		get => this[Addresses.Y6];
		set => this[Addresses.Y6] = value;
	}


	/// <summary>
	/// B13
	/// </summary>
	public object Z6 {
		get => this[Addresses.Z6];
		set => this[Addresses.Z6] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object CQ141 {
		get => this[Addresses.CQ141];
		set => this[Addresses.CQ141] = value;
	}


	/// <summary>
	/// IF(CQ141=0,0,5)
	/// </summary>
	public object CR141 {
		get => this[Addresses.CR141];
		set => this[Addresses.CR141] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object BT141 {
		get => this[Addresses.BT141];
		set => this[Addresses.BT141] = value;
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
	/// +MAX(B20,B21)
	/// </summary>
	public object AB15 {
		get => this[Addresses.AB15];
		set => this[Addresses.AB15] = value;
	}


	/// <summary>
	/// +MIN(B20,B21)
	/// </summary>
	public object Z15 {
		get => this[Addresses.Z15];
		set => this[Addresses.Z15] = value;
	}


	/// <summary>
	/// +(AB15-Z15)/30
	/// </summary>
	public object Y13 {
		get => this[Addresses.Y13];
		set => this[Addresses.Y13] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B22 {
		get => this[Addresses.B22];
		set => this[Addresses.B22] = value;
	}


	/// <summary>
	/// B22
	/// </summary>
	public object AC15 {
		get => this[Addresses.AC15];
		set => this[Addresses.AC15] = value;
	}


	/// <summary>
	/// +AC15
	/// </summary>
	public object Z141 {
		get => this[Addresses.Z141];
		set => this[Addresses.Z141] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B62 {
		get => this[Addresses.B62];
		set => this[Addresses.B62] = value;
	}


	/// <summary>
	/// B62
	/// </summary>
	public object AC11 {
		get => this[Addresses.AC11];
		set => this[Addresses.AC11] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public object B31 {
		get => this[Addresses.B31];
		set => this[Addresses.B31] = value;
	}


	/// <summary>
	/// +B31
	/// </summary>
	public object AC8 {
		get => this[Addresses.AC8];
		set => this[Addresses.AC8] = value;
	}


	/// <summary>
	/// +AC8
	/// </summary>
	public object AK141 {
		get => this[Addresses.AK141];
		set => this[Addresses.AK141] = value;
	}


	/// <summary>
	/// +AK141
	/// </summary>
	public object BS141 {
		get => this[Addresses.BS141];
		set => this[Addresses.BS141] = value;
	}


	/// <summary>
	/// IF(((BS141-BT141)*(AC11/(2^(1/3)))/250)<1,((BS141-BT141)*(AC11/(2^(1/3)))/250),1)
	/// </summary>
	public object BU141 {
		get => this[Addresses.BU141];
		set => this[Addresses.BU141] = value;
	}


	/// <summary>
	/// B11-X141
	/// </summary>
	public object AT141 {
		get => this[Addresses.AT141];
		set => this[Addresses.AT141] = value;
	}


	/// <summary>
	/// +Z15
	/// </summary>
	public object Y80 {
		get => this[Addresses.Y80];
		set => this[Addresses.Y80] = value;
	}


	/// <summary>
	/// +Y80
	/// </summary>
	public object Y111 {
		get => this[Addresses.Y111];
		set => this[Addresses.Y111] = value;
	}


	/// <summary>
	/// +Y111+Y13
	/// </summary>
	public object Y112 {
		get => this[Addresses.Y112];
		set => this[Addresses.Y112] = value;
	}


	/// <summary>
	/// +Y112+Y13
	/// </summary>
	public object Y113 {
		get => this[Addresses.Y113];
		set => this[Addresses.Y113] = value;
	}


	/// <summary>
	/// +Y113+Y13
	/// </summary>
	public object Y114 {
		get => this[Addresses.Y114];
		set => this[Addresses.Y114] = value;
	}


	/// <summary>
	/// +Y114+Y13
	/// </summary>
	public object Y115 {
		get => this[Addresses.Y115];
		set => this[Addresses.Y115] = value;
	}


	/// <summary>
	/// +Y115+Y13
	/// </summary>
	public object Y116 {
		get => this[Addresses.Y116];
		set => this[Addresses.Y116] = value;
	}


	/// <summary>
	/// +Y116+Y13
	/// </summary>
	public object Y117 {
		get => this[Addresses.Y117];
		set => this[Addresses.Y117] = value;
	}


	/// <summary>
	/// +Y117+Y13
	/// </summary>
	public object Y118 {
		get => this[Addresses.Y118];
		set => this[Addresses.Y118] = value;
	}


	/// <summary>
	/// +Y118+Y13
	/// </summary>
	public object Y119 {
		get => this[Addresses.Y119];
		set => this[Addresses.Y119] = value;
	}


	/// <summary>
	/// +Y119+Y13
	/// </summary>
	public object Y120 {
		get => this[Addresses.Y120];
		set => this[Addresses.Y120] = value;
	}


	/// <summary>
	/// +Y120+Y13
	/// </summary>
	public object Y121 {
		get => this[Addresses.Y121];
		set => this[Addresses.Y121] = value;
	}


	/// <summary>
	/// +Y121+Y13
	/// </summary>
	public object Y122 {
		get => this[Addresses.Y122];
		set => this[Addresses.Y122] = value;
	}


	/// <summary>
	/// +Y122+Y13
	/// </summary>
	public object Y123 {
		get => this[Addresses.Y123];
		set => this[Addresses.Y123] = value;
	}


	/// <summary>
	/// +Y123+Y13
	/// </summary>
	public object Y124 {
		get => this[Addresses.Y124];
		set => this[Addresses.Y124] = value;
	}


	/// <summary>
	/// +Y124+Y13
	/// </summary>
	public object Y125 {
		get => this[Addresses.Y125];
		set => this[Addresses.Y125] = value;
	}


	/// <summary>
	/// +Y125+Y13
	/// </summary>
	public object Y126 {
		get => this[Addresses.Y126];
		set => this[Addresses.Y126] = value;
	}


	/// <summary>
	/// +Y126+Y13
	/// </summary>
	public object Y127 {
		get => this[Addresses.Y127];
		set => this[Addresses.Y127] = value;
	}


	/// <summary>
	/// +Y127+Y13
	/// </summary>
	public object Y128 {
		get => this[Addresses.Y128];
		set => this[Addresses.Y128] = value;
	}


	/// <summary>
	/// +Y128+Y13
	/// </summary>
	public object Y129 {
		get => this[Addresses.Y129];
		set => this[Addresses.Y129] = value;
	}


	/// <summary>
	/// +Y129+Y13
	/// </summary>
	public object Y130 {
		get => this[Addresses.Y130];
		set => this[Addresses.Y130] = value;
	}


	/// <summary>
	/// +Y130+Y13
	/// </summary>
	public object Y131 {
		get => this[Addresses.Y131];
		set => this[Addresses.Y131] = value;
	}


	/// <summary>
	/// +Y131+Y13
	/// </summary>
	public object Y132 {
		get => this[Addresses.Y132];
		set => this[Addresses.Y132] = value;
	}


	/// <summary>
	/// +Y132+Y13
	/// </summary>
	public object Y133 {
		get => this[Addresses.Y133];
		set => this[Addresses.Y133] = value;
	}


	/// <summary>
	/// +Y133+Y13
	/// </summary>
	public object Y134 {
		get => this[Addresses.Y134];
		set => this[Addresses.Y134] = value;
	}


	/// <summary>
	/// +Y134+Y13
	/// </summary>
	public object Y135 {
		get => this[Addresses.Y135];
		set => this[Addresses.Y135] = value;
	}


	/// <summary>
	/// +Y135+Y13
	/// </summary>
	public object Y136 {
		get => this[Addresses.Y136];
		set => this[Addresses.Y136] = value;
	}


	/// <summary>
	/// +Y136+Y13
	/// </summary>
	public object Y137 {
		get => this[Addresses.Y137];
		set => this[Addresses.Y137] = value;
	}


	/// <summary>
	/// +Y137+Y13
	/// </summary>
	public object Y138 {
		get => this[Addresses.Y138];
		set => this[Addresses.Y138] = value;
	}


	/// <summary>
	/// +Y138+Y13
	/// </summary>
	public object Y139 {
		get => this[Addresses.Y139];
		set => this[Addresses.Y139] = value;
	}


	/// <summary>
	/// +Y139+Y13
	/// </summary>
	public object Y140 {
		get => this[Addresses.Y140];
		set => this[Addresses.Y140] = value;
	}


	/// <summary>
	/// +Y140+Y13
	/// </summary>
	public object Y141 {
		get => this[Addresses.Y141];
		set => this[Addresses.Y141] = value;
	}


	/// <summary>
	/// IF(Y8>=Y15,IF(Y141<AB8,IF(Y141>Z8,1,0),0),0)
	/// </summary>
	public object CS141 {
		get => this[Addresses.CS141];
		set => this[Addresses.CS141] = value;
	}


	/// <summary>
	/// +SQRT(((X6-X141)^2)+((Y141-Y6)^2)+((Z141-Z6)^2))
	/// </summary>
	public object BY141 {
		get => this[Addresses.BY141];
		set => this[Addresses.BY141] = value;
	}


	/// <summary>
	/// +SQRT(((X6-X141)^2)+((Y141+Y6)^2)+((Z141-Z6)^2))
	/// </summary>
	public object CT141 {
		get => this[Addresses.CT141];
		set => this[Addresses.CT141] = value;
	}


	/// <summary>
	/// X6+(Y6*(X141-X6)/(Y141+Y6))
	/// </summary>
	public object CA141 {
		get => this[Addresses.CA141];
		set => this[Addresses.CA141] = value;
	}


	/// <summary>
	/// IF(CA141>=X10,IF(CA141<=Y10,1,""),"")
	/// </summary>
	public object CB141 {
		get => this[Addresses.CB141];
		set => this[Addresses.CB141] = value;
	}


	/// <summary>
	/// IF(CB141=1,IF((B50<1),(+AC10-(10*LOG10(PI()*2*(CT141^2)))-CR141-1+(10*LOG10(1-B50))),-9999),-9999)
	/// </summary>
	public object CU141 {
		get => this[Addresses.CU141];
		set => this[Addresses.CU141] = value;
	}


	/// <summary>
	/// +Y6+((Y141-Y6)*(Y8-X6)/(X141-X6))
	/// </summary>
	public object AC141 {
		get => this[Addresses.AC141];
		set => this[Addresses.AC141] = value;
	}


	/// <summary>
	/// IF(AC141<Z8,Z8,IF(AC141>AB8,AB8,AC141))
	/// </summary>
	public object AG141 {
		get => this[Addresses.AG141];
		set => this[Addresses.AG141] = value;
	}


	/// <summary>
	/// IF((Y141-Y6)<>0,(+X6+((X141-X6)*(Z8-Y6)/(Y141-Y6))),-100000)
	/// </summary>
	public object AD141 {
		get => this[Addresses.AD141];
		set => this[Addresses.AD141] = value;
	}


	/// <summary>
	/// IF((Y141-Y6)<>0,(+X6+((X141-X6)*(AB8-Y6)/(Y141-Y6))),100000)
	/// </summary>
	public object AE141 {
		get => this[Addresses.AE141];
		set => this[Addresses.AE141] = value;
	}


	/// <summary>
	/// IF(AC141<Z8,AD141,IF(AC141>AB8,AE141,Y8))
	/// </summary>
	public object AF141 {
		get => this[Addresses.AF141];
		set => this[Addresses.AF141] = value;
	}


	/// <summary>
	/// +SQRT(((AF141-X6)^2)+((Y6-AG141)^2))
	/// </summary>
	public object AH141 {
		get => this[Addresses.AH141];
		set => this[Addresses.AH141] = value;
	}


	/// <summary>
	/// +SQRT((AH141^2)+((AK141-Z6)^2))
	/// </summary>
	public object AL141 {
		get => this[Addresses.AL141];
		set => this[Addresses.AL141] = value;
	}


	/// <summary>
	/// +SQRT(((X141-AF141)^2)+((Y141-AG141)^2))
	/// </summary>
	public object AI141 {
		get => this[Addresses.AI141];
		set => this[Addresses.AI141] = value;
	}


	/// <summary>
	/// +Z6+((Z141-Z6)*AH141/(AH141+AI141))
	/// </summary>
	public object AJ141 {
		get => this[Addresses.AJ141];
		set => this[Addresses.AJ141] = value;
	}


	/// <summary>
	/// +SQRT(AI141^2+((AK141-Z141)^2))
	/// </summary>
	public object AM141 {
		get => this[Addresses.AM141];
		set => this[Addresses.AM141] = value;
	}


	/// <summary>
	/// +SQRT(AH141^2+((AJ141-Z6)^2))
	/// </summary>
	public object AN141 {
		get => this[Addresses.AN141];
		set => this[Addresses.AN141] = value;
	}


	/// <summary>
	/// +SQRT((AI141^2)+((AJ141-Z141)^2))
	/// </summary>
	public object AO141 {
		get => this[Addresses.AO141];
		set => this[Addresses.AO141] = value;
	}


	/// <summary>
	/// +IF(AK141>AJ141,(AL141+AM141-AN141-AO141),(AN141+AO141-AL141-AM141))
	/// </summary>
	public object AR141 {
		get => this[Addresses.AR141];
		set => this[Addresses.AR141] = value;
	}


	/// <summary>
	/// 0.0059*AR141*(AC11/(2^(1/3)))
	/// </summary>
	public object AS141 {
		get => this[Addresses.AS141];
		set => this[Addresses.AS141] = value;
	}


	/// <summary>
	/// B12-Y141
	/// </summary>
	public object AU141 {
		get => this[Addresses.AU141];
		set => this[Addresses.AU141] = value;
	}


	/// <summary>
	/// -((AT141^2)+(AU141^2))/(B13-Z141)
	/// </summary>
	public object AV141 {
		get => this[Addresses.AV141];
		set => this[Addresses.AV141] = value;
	}


	/// <summary>
	/// SQRT((AT141^2)+(AU141^2)+(AV141^2))
	/// </summary>
	public object AW141 {
		get => this[Addresses.AW141];
		set => this[Addresses.AW141] = value;
	}


	/// <summary>
	/// AT141/AW141
	/// </summary>
	public object AX141 {
		get => this[Addresses.AX141];
		set => this[Addresses.AX141] = value;
	}


	/// <summary>
	/// AU141/AW141
	/// </summary>
	public object AY141 {
		get => this[Addresses.AY141];
		set => this[Addresses.AY141] = value;
	}


	/// <summary>
	/// AV141/AW141
	/// </summary>
	public object AZ141 {
		get => this[Addresses.AZ141];
		set => this[Addresses.AZ141] = value;
	}


	/// <summary>
	/// -((AX141*B11)+(AY141*B12)+(AZ141*B13))
	/// </summary>
	public object BA141 {
		get => this[Addresses.BA141];
		set => this[Addresses.BA141] = value;
	}


	/// <summary>
	/// IF(AX141<>0,(-(BA141+(AY141*Z8)+(AZ141*AC8))/AX141),1000)
	/// </summary>
	public object BD141 {
		get => this[Addresses.BD141];
		set => this[Addresses.BD141] = value;
	}


	/// <summary>
	/// ((((X6-BD141)^2)+((Y6-Z8)^2)+((Z6-AC8)^2))^0.5)+((((BD141-X141)^2)+((Z8-Y141)^2)+((AC8-Z141)^2))^0.5)-BY141
	/// </summary>
	public object BJ141 {
		get => this[Addresses.BJ141];
		set => this[Addresses.BJ141] = value;
	}


	/// <summary>
	/// IF(AX141<>0,(-(BA141+(AY141*B30)+(AZ141*B31))/AX141),1000)
	/// </summary>
	public object BE141 {
		get => this[Addresses.BE141];
		set => this[Addresses.BE141] = value;
	}


	/// <summary>
	/// ((((X6-BE141)^2)+((Y6-AB8)^2)+((Z6-AC8)^2))^0.5)+((((BE141-X141)^2)+((AB8-Y141)^2)+((AC8-Z141)^2))^0.5)-BY141
	/// </summary>
	public object BM141 {
		get => this[Addresses.BM141];
		set => this[Addresses.BM141] = value;
	}


	/// <summary>
	/// MIN(BJ141:BM141)
	/// </summary>
	public object BQ141 {
		get => this[Addresses.BQ141];
		set => this[Addresses.BQ141] = value;
	}


	/// <summary>
	/// 0.0059*BQ141*(AC11/(2^(1/3)))
	/// </summary>
	public object BR141 {
		get => this[Addresses.BR141];
		set => this[Addresses.BR141] = value;
	}


	/// <summary>
	/// +IF(AS141>(-0.1),(10*BU141*LOG10(1/((1/(20*AS141+3))+(1/(20*BR141+3))))),0)
	/// </summary>
	public object BW141 {
		get => this[Addresses.BW141];
		set => this[Addresses.BW141] = value;
	}


	/// <summary>
	/// +AC10-(10*LOG10(PI()*2*(BY141^2)))-BW141-1
	/// </summary>
	public object BZ141 {
		get => this[Addresses.BZ141];
		set => this[Addresses.BZ141] = value;
	}


	/// <summary>
	/// IF(L141=1,IF(CS141=0,ROUND(10*LOG10((10^(BZ141/10))+(10^(CU141/10))),0),""),"")
	/// </summary>
	public object CV141 {
		get => this[Addresses.CV141];
		set => this[Addresses.CV141] = value;
	}


	/// <summary>
	/// MAX(CV18:CV141)
	/// </summary>
	public object F60 {
		get => this[Addresses.F60];
		set => this[Addresses.F60] = value;
	}


	/// <summary>
	/// B15-F60
	/// </summary>
	public object F59 {
		get => this[Addresses.F59];
		set => this[Addresses.F59] = value;
	}


	/// <summary>
	/// IF(F33<>"nvt",ROUND(45+F59,0),"")
	/// </summary>
	public object F65 {
		get => this[Addresses.F65];
		set => this[Addresses.F65] = value;
	}


	/// <summary>
	/// IF(F65<>"",-F65,-9999)
	/// </summary>
	public object F68 {
		get => this[Addresses.F68];
		set => this[Addresses.F68] = value;
	}


	/// <summary>
	/// (-MAX(C68:F68))-B16
	/// </summary>
	public object C45 {
		get => this[Addresses.C45];
		set => this[Addresses.C45] = value;
	}


	/// <summary>
	/// ROUND(C45,0)
	/// </summary>
	public object C74 {
		get => this[Addresses.C74];
		set => this[Addresses.C74] = value;
	}


	/// <summary>
	/// IF(C88<=C74,"VOLDOET","VOLDOET NIET")
	/// </summary>
	public object B89 {
		get => this[Addresses.B89];
		set => this[Addresses.B89] = value;
	}


	/// <summary>
	/// C45-5
	/// </summary>
	public object C46 {
		get => this[Addresses.C46];
		set => this[Addresses.C46] = value;
	}


	/// <summary>
	/// ROUND(C46,0)
	/// </summary>
	public object F74 {
		get => this[Addresses.F74];
		set => this[Addresses.F74] = value;
	}


	/// <summary>
	/// IF(F88<=F74,"VOLDOET","VOLDOET NIET")
	/// </summary>
	public object E89 {
		get => this[Addresses.E89];
		set => this[Addresses.E89] = value;
	}

	
	protected override IEnumerable<KeyValuePair<string, Func<object>>> GetFormulas()
	{
		yield return new KeyValuePair<string, Func<object>>("C88", () => Subtract(Add(C85, C86), C87));
		yield return new KeyValuePair<string, Func<object>>("F88", () => Subtract(Add(F85, F86), F87));
		yield return new KeyValuePair<string, Func<object>>("C56", () => SQRT(Add(Add((Pow((Subtract(B11, C33)), 2)), (Pow((Subtract(B12, C34)), 2))), (Pow((Subtract(B13, C35)), 2)))));
		yield return new KeyValuePair<string, Func<object>>("C57", () => IF(object.Equals(C36, "J"), 5, 0));
		yield return new KeyValuePair<string, Func<object>>("C58", () => Multiply(10, LOG10(Divide(2, C37))));
		yield return new KeyValuePair<string, Func<object>>("C59", () => IF(object.Equals(C33, "nvt"), 9999, (Subtract(Add(Add(Multiply(20, LOG10(C56)), 9), C57), C58))));
		yield return new KeyValuePair<string, Func<object>>("C65", () => IF(!object.Equals(C33, "nvt"), ROUND(Add(45, C59), 0), ""));
		yield return new KeyValuePair<string, Func<object>>("C68", () => IF(!object.Equals(C65, ""), Negate(C65), Negate(9999)));
		yield return new KeyValuePair<string, Func<object>>("L141", () => IF(object.Equals(I19, "j"), 1, 0));
		yield return new KeyValuePair<string, Func<object>>("AC10", () => B15);
		yield return new KeyValuePair<string, Func<object>>("Y8", () => B28);
		yield return new KeyValuePair<string, Func<object>>("Y15", () => Plus(MAX(B18, B19)));
		yield return new KeyValuePair<string, Func<object>>("AB8", () => Plus(B30));
		yield return new KeyValuePair<string, Func<object>>("Z8", () => B29);
		yield return new KeyValuePair<string, Func<object>>("X6", () => B11);
		yield return new KeyValuePair<string, Func<object>>("X141", () => Plus(Y15));
		yield return new KeyValuePair<string, Func<object>>("Y6", () => B12);
		yield return new KeyValuePair<string, Func<object>>("Z6", () => B13);
		yield return new KeyValuePair<string, Func<object>>("CR141", () => IF(object.Equals(CQ141, 0), 0, 5));
		yield return new KeyValuePair<string, Func<object>>("X10", () => B24);
		yield return new KeyValuePair<string, Func<object>>("Y10", () => B25);
		yield return new KeyValuePair<string, Func<object>>("AB15", () => Plus(MAX(B20, B21)));
		yield return new KeyValuePair<string, Func<object>>("Z15", () => Plus(MIN(B20, B21)));
		yield return new KeyValuePair<string, Func<object>>("Y13", () => Divide(Plus((Subtract(AB15, Z15))), 30));
		yield return new KeyValuePair<string, Func<object>>("AC15", () => B22);
		yield return new KeyValuePair<string, Func<object>>("Z141", () => Plus(AC15));
		yield return new KeyValuePair<string, Func<object>>("AC11", () => B62);
		yield return new KeyValuePair<string, Func<object>>("AC8", () => Plus(B31));
		yield return new KeyValuePair<string, Func<object>>("AK141", () => Plus(AC8));
		yield return new KeyValuePair<string, Func<object>>("BS141", () => Plus(AK141));
		yield return new KeyValuePair<string, Func<object>>("BU141", () => IF(Less((Divide(Multiply((Subtract(BS141, BT141)), (Divide(AC11, (Pow(2, (Divide(1, 3))))))), 250)), 1), (Divide(Multiply((Subtract(BS141, BT141)), (Divide(AC11, (Pow(2, (Divide(1, 3))))))), 250)), 1));
		yield return new KeyValuePair<string, Func<object>>("AT141", () => Subtract(B11, X141));
		yield return new KeyValuePair<string, Func<object>>("Y80", () => Plus(Z15));
		yield return new KeyValuePair<string, Func<object>>("Y111", () => Plus(Y80));
		yield return new KeyValuePair<string, Func<object>>("Y112", () => Add(Plus(Y111), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y113", () => Add(Plus(Y112), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y114", () => Add(Plus(Y113), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y115", () => Add(Plus(Y114), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y116", () => Add(Plus(Y115), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y117", () => Add(Plus(Y116), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y118", () => Add(Plus(Y117), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y119", () => Add(Plus(Y118), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y120", () => Add(Plus(Y119), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y121", () => Add(Plus(Y120), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y122", () => Add(Plus(Y121), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y123", () => Add(Plus(Y122), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y124", () => Add(Plus(Y123), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y125", () => Add(Plus(Y124), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y126", () => Add(Plus(Y125), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y127", () => Add(Plus(Y126), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y128", () => Add(Plus(Y127), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y129", () => Add(Plus(Y128), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y130", () => Add(Plus(Y129), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y131", () => Add(Plus(Y130), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y132", () => Add(Plus(Y131), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y133", () => Add(Plus(Y132), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y134", () => Add(Plus(Y133), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y135", () => Add(Plus(Y134), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y136", () => Add(Plus(Y135), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y137", () => Add(Plus(Y136), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y138", () => Add(Plus(Y137), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y139", () => Add(Plus(Y138), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y140", () => Add(Plus(Y139), Y13));
		yield return new KeyValuePair<string, Func<object>>("Y141", () => Add(Plus(Y140), Y13));
		yield return new KeyValuePair<string, Func<object>>("CS141", () => IF(GreaterOrEqual(Y8, Y15), IF(Less(Y141, AB8), IF(Greater(Y141, Z8), 1, 0), 0), 0));
		yield return new KeyValuePair<string, Func<object>>("BY141", () => Plus(SQRT(Add(Add((Pow((Subtract(X6, X141)), 2)), (Pow((Subtract(Y141, Y6)), 2))), (Pow((Subtract(Z141, Z6)), 2))))));
		yield return new KeyValuePair<string, Func<object>>("CT141", () => Plus(SQRT(Add(Add((Pow((Subtract(X6, X141)), 2)), (Pow((Add(Y141, Y6)), 2))), (Pow((Subtract(Z141, Z6)), 2))))));
		yield return new KeyValuePair<string, Func<object>>("CA141", () => Add(X6, (Divide(Multiply(Y6, (Subtract(X141, X6))), (Add(Y141, Y6))))));
		yield return new KeyValuePair<string, Func<object>>("CB141", () => IF(GreaterOrEqual(CA141, X10), IF(LessOrEqual(CA141, Y10), 1, ""), ""));
		yield return new KeyValuePair<string, Func<object>>("CU141", () => IF(object.Equals(CB141, 1), IF((Less(B50, 1)), (Add(Subtract(Subtract(Subtract(Plus(AC10), (Multiply(10, LOG10(Multiply(Multiply(PI(), 2), (Pow(CT141, 2))))))), CR141), 1), (Multiply(10, LOG10(Subtract(1, B50)))))), Negate(9999)), Negate(9999)));
		yield return new KeyValuePair<string, Func<object>>("AC141", () => Add(Plus(Y6), (Divide(Multiply((Subtract(Y141, Y6)), (Subtract(Y8, X6))), (Subtract(X141, X6))))));
		yield return new KeyValuePair<string, Func<object>>("AG141", () => IF(Less(AC141, Z8), Z8, IF(Greater(AC141, AB8), AB8, AC141)));
		yield return new KeyValuePair<string, Func<object>>("AD141", () => IF(!object.Equals((Subtract(Y141, Y6)), 0), (Add(Plus(X6), (Divide(Multiply((Subtract(X141, X6)), (Subtract(Z8, Y6))), (Subtract(Y141, Y6)))))), Negate(100000)));
		yield return new KeyValuePair<string, Func<object>>("AE141", () => IF(!object.Equals((Subtract(Y141, Y6)), 0), (Add(Plus(X6), (Divide(Multiply((Subtract(X141, X6)), (Subtract(AB8, Y6))), (Subtract(Y141, Y6)))))), 100000));
		yield return new KeyValuePair<string, Func<object>>("AF141", () => IF(Less(AC141, Z8), AD141, IF(Greater(AC141, AB8), AE141, Y8)));
		yield return new KeyValuePair<string, Func<object>>("AH141", () => Plus(SQRT(Add((Pow((Subtract(AF141, X6)), 2)), (Pow((Subtract(Y6, AG141)), 2))))));
		yield return new KeyValuePair<string, Func<object>>("AL141", () => Plus(SQRT(Add((Pow(AH141, 2)), (Pow((Subtract(AK141, Z6)), 2))))));
		yield return new KeyValuePair<string, Func<object>>("AI141", () => Plus(SQRT(Add((Pow((Subtract(X141, AF141)), 2)), (Pow((Subtract(Y141, AG141)), 2))))));
		yield return new KeyValuePair<string, Func<object>>("AJ141", () => Add(Plus(Z6), (Divide(Multiply((Subtract(Z141, Z6)), AH141), (Add(AH141, AI141))))));
		yield return new KeyValuePair<string, Func<object>>("AM141", () => Plus(SQRT(Pow(AI141, Add(2, (Pow((Subtract(AK141, Z141)), 2)))))));
		yield return new KeyValuePair<string, Func<object>>("AN141", () => Plus(SQRT(Pow(AH141, Add(2, (Pow((Subtract(AJ141, Z6)), 2)))))));
		yield return new KeyValuePair<string, Func<object>>("AO141", () => Plus(SQRT(Add((Pow(AI141, 2)), (Pow((Subtract(AJ141, Z141)), 2))))));
		yield return new KeyValuePair<string, Func<object>>("AR141", () => Plus(IF(Greater(AK141, AJ141), (Subtract(Subtract(Add(AL141, AM141), AN141), AO141)), (Subtract(Subtract(Add(AN141, AO141), AL141), AM141)))));
		yield return new KeyValuePair<string, Func<object>>("AS141", () => Multiply(Multiply(0.0059, AR141), (Divide(AC11, (Pow(2, (Divide(1, 3))))))));
		yield return new KeyValuePair<string, Func<object>>("AU141", () => Subtract(B12, Y141));
		yield return new KeyValuePair<string, Func<object>>("AV141", () => Divide(Negate((Add((Pow(AT141, 2)), (Pow(AU141, 2))))), (Subtract(B13, Z141))));
		yield return new KeyValuePair<string, Func<object>>("AW141", () => SQRT(Add(Add((Pow(AT141, 2)), (Pow(AU141, 2))), (Pow(AV141, 2)))));
		yield return new KeyValuePair<string, Func<object>>("AX141", () => Divide(AT141, AW141));
		yield return new KeyValuePair<string, Func<object>>("AY141", () => Divide(AU141, AW141));
		yield return new KeyValuePair<string, Func<object>>("AZ141", () => Divide(AV141, AW141));
		yield return new KeyValuePair<string, Func<object>>("BA141", () => Negate((Add(Add((Multiply(AX141, B11)), (Multiply(AY141, B12))), (Multiply(AZ141, B13))))));
		yield return new KeyValuePair<string, Func<object>>("BD141", () => IF(!object.Equals(AX141, 0), (Divide(Negate((Add(Add(BA141, (Multiply(AY141, Z8))), (Multiply(AZ141, AC8))))), AX141)), 1000));
		yield return new KeyValuePair<string, Func<object>>("BJ141", () => Subtract(Add((Pow((Add(Add((Pow((Subtract(X6, BD141)), 2)), (Pow((Subtract(Y6, Z8)), 2))), (Pow((Subtract(Z6, AC8)), 2)))), 0.5)), (Pow((Add(Add((Pow((Subtract(BD141, X141)), 2)), (Pow((Subtract(Z8, Y141)), 2))), (Pow((Subtract(AC8, Z141)), 2)))), 0.5))), BY141));
		yield return new KeyValuePair<string, Func<object>>("BE141", () => IF(!object.Equals(AX141, 0), (Divide(Negate((Add(Add(BA141, (Multiply(AY141, B30))), (Multiply(AZ141, B31))))), AX141)), 1000));
		yield return new KeyValuePair<string, Func<object>>("BM141", () => Subtract(Add((Pow((Add(Add((Pow((Subtract(X6, BE141)), 2)), (Pow((Subtract(Y6, AB8)), 2))), (Pow((Subtract(Z6, AC8)), 2)))), 0.5)), (Pow((Add(Add((Pow((Subtract(BE141, X141)), 2)), (Pow((Subtract(AB8, Y141)), 2))), (Pow((Subtract(AC8, Z141)), 2)))), 0.5))), BY141));
		yield return new KeyValuePair<string, Func<object>>("BQ141", () => MIN(new CellRange(Addresses.BJ141, Addresses.BM141)));
		yield return new KeyValuePair<string, Func<object>>("BR141", () => Multiply(Multiply(0.0059, BQ141), (Divide(AC11, (Pow(2, (Divide(1, 3))))))));
		yield return new KeyValuePair<string, Func<object>>("BW141", () => Plus(IF(Greater(AS141, (Negate(0.1))), (Multiply(Multiply(10, BU141), LOG10(Divide(1, (Add((Divide(1, (Add(Multiply(20, AS141), 3)))), (Divide(1, (Add(Multiply(20, BR141), 3)))))))))), 0)));
		yield return new KeyValuePair<string, Func<object>>("BZ141", () => Subtract(Subtract(Subtract(Plus(AC10), (Multiply(10, LOG10(Multiply(Multiply(PI(), 2), (Pow(BY141, 2))))))), BW141), 1));
		yield return new KeyValuePair<string, Func<object>>("CV141", () => IF(object.Equals(L141, 1), IF(object.Equals(CS141, 0), ROUND(Multiply(10, LOG10(Add((Pow(10, (Divide(BZ141, 10)))), (Pow(10, (Divide(CU141, 10))))))), 0), ""), ""));
		yield return new KeyValuePair<string, Func<object>>("F60", () => MAX(new CellRange(Addresses.CV18, Addresses.CV141)));
		yield return new KeyValuePair<string, Func<object>>("F59", () => Subtract(B15, F60));
		yield return new KeyValuePair<string, Func<object>>("F65", () => IF(!object.Equals(F33, "nvt"), ROUND(Add(45, F59), 0), ""));
		yield return new KeyValuePair<string, Func<object>>("F68", () => IF(!object.Equals(F65, ""), Negate(F65), Negate(9999)));
		yield return new KeyValuePair<string, Func<object>>("C45", () => Subtract((Negate(MAX(new CellRange(Addresses.C68, Addresses.F68)))), B16));
		yield return new KeyValuePair<string, Func<object>>("C74", () => ROUND(C45, 0));
		yield return new KeyValuePair<string, Func<object>>("B89", () => IF(LessOrEqual(C88, C74), "VOLDOET", "VOLDOET NIET"));
		yield return new KeyValuePair<string, Func<object>>("C46", () => Subtract(C45, 5));
		yield return new KeyValuePair<string, Func<object>>("F74", () => ROUND(C46, 0));
		yield return new KeyValuePair<string, Func<object>>("E89", () => IF(LessOrEqual(F88, F74), "VOLDOET", "VOLDOET NIET"));
	}
	
	public static class Addresses
	{
		public static readonly CellRef AB15 = CellRef.Parse("AB15");
		public static readonly CellRef AB8 = CellRef.Parse("AB8");
		public static readonly CellRef AC10 = CellRef.Parse("AC10");
		public static readonly CellRef AC11 = CellRef.Parse("AC11");
		public static readonly CellRef AC141 = CellRef.Parse("AC141");
		public static readonly CellRef AC15 = CellRef.Parse("AC15");
		public static readonly CellRef AC8 = CellRef.Parse("AC8");
		public static readonly CellRef AD141 = CellRef.Parse("AD141");
		public static readonly CellRef AE141 = CellRef.Parse("AE141");
		public static readonly CellRef AF141 = CellRef.Parse("AF141");
		public static readonly CellRef AG141 = CellRef.Parse("AG141");
		public static readonly CellRef AH141 = CellRef.Parse("AH141");
		public static readonly CellRef AI141 = CellRef.Parse("AI141");
		public static readonly CellRef AJ141 = CellRef.Parse("AJ141");
		public static readonly CellRef AK141 = CellRef.Parse("AK141");
		public static readonly CellRef AL141 = CellRef.Parse("AL141");
		public static readonly CellRef AM141 = CellRef.Parse("AM141");
		public static readonly CellRef AN141 = CellRef.Parse("AN141");
		public static readonly CellRef AO141 = CellRef.Parse("AO141");
		public static readonly CellRef AR141 = CellRef.Parse("AR141");
		public static readonly CellRef AS141 = CellRef.Parse("AS141");
		public static readonly CellRef AT141 = CellRef.Parse("AT141");
		public static readonly CellRef AU141 = CellRef.Parse("AU141");
		public static readonly CellRef AV141 = CellRef.Parse("AV141");
		public static readonly CellRef AW141 = CellRef.Parse("AW141");
		public static readonly CellRef AX141 = CellRef.Parse("AX141");
		public static readonly CellRef AY141 = CellRef.Parse("AY141");
		public static readonly CellRef AZ141 = CellRef.Parse("AZ141");
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
		public static readonly CellRef B28 = CellRef.Parse("B28");
		public static readonly CellRef B29 = CellRef.Parse("B29");
		public static readonly CellRef B30 = CellRef.Parse("B30");
		public static readonly CellRef B31 = CellRef.Parse("B31");
		public static readonly CellRef B50 = CellRef.Parse("B50");
		public static readonly CellRef B62 = CellRef.Parse("B62");
		public static readonly CellRef B89 = CellRef.Parse("B89");
		public static readonly CellRef BA141 = CellRef.Parse("BA141");
		public static readonly CellRef BD141 = CellRef.Parse("BD141");
		public static readonly CellRef BE141 = CellRef.Parse("BE141");
		public static readonly CellRef BJ141 = CellRef.Parse("BJ141");
		public static readonly CellRef BM141 = CellRef.Parse("BM141");
		public static readonly CellRef BQ141 = CellRef.Parse("BQ141");
		public static readonly CellRef BR141 = CellRef.Parse("BR141");
		public static readonly CellRef BS141 = CellRef.Parse("BS141");
		public static readonly CellRef BT141 = CellRef.Parse("BT141");
		public static readonly CellRef BU141 = CellRef.Parse("BU141");
		public static readonly CellRef BW141 = CellRef.Parse("BW141");
		public static readonly CellRef BY141 = CellRef.Parse("BY141");
		public static readonly CellRef BZ141 = CellRef.Parse("BZ141");
		public static readonly CellRef C33 = CellRef.Parse("C33");
		public static readonly CellRef C34 = CellRef.Parse("C34");
		public static readonly CellRef C35 = CellRef.Parse("C35");
		public static readonly CellRef C36 = CellRef.Parse("C36");
		public static readonly CellRef C37 = CellRef.Parse("C37");
		public static readonly CellRef C45 = CellRef.Parse("C45");
		public static readonly CellRef C46 = CellRef.Parse("C46");
		public static readonly CellRef C56 = CellRef.Parse("C56");
		public static readonly CellRef C57 = CellRef.Parse("C57");
		public static readonly CellRef C58 = CellRef.Parse("C58");
		public static readonly CellRef C59 = CellRef.Parse("C59");
		public static readonly CellRef C65 = CellRef.Parse("C65");
		public static readonly CellRef C68 = CellRef.Parse("C68");
		public static readonly CellRef C74 = CellRef.Parse("C74");
		public static readonly CellRef C85 = CellRef.Parse("C85");
		public static readonly CellRef C86 = CellRef.Parse("C86");
		public static readonly CellRef C87 = CellRef.Parse("C87");
		public static readonly CellRef C88 = CellRef.Parse("C88");
		public static readonly CellRef CA141 = CellRef.Parse("CA141");
		public static readonly CellRef CB141 = CellRef.Parse("CB141");
		public static readonly CellRef CQ141 = CellRef.Parse("CQ141");
		public static readonly CellRef CR141 = CellRef.Parse("CR141");
		public static readonly CellRef CS141 = CellRef.Parse("CS141");
		public static readonly CellRef CT141 = CellRef.Parse("CT141");
		public static readonly CellRef CU141 = CellRef.Parse("CU141");
		public static readonly CellRef CV141 = CellRef.Parse("CV141");
		public static readonly CellRef CV18 = CellRef.Parse("CV18");
		public static readonly CellRef E89 = CellRef.Parse("E89");
		public static readonly CellRef F33 = CellRef.Parse("F33");
		public static readonly CellRef F59 = CellRef.Parse("F59");
		public static readonly CellRef F60 = CellRef.Parse("F60");
		public static readonly CellRef F65 = CellRef.Parse("F65");
		public static readonly CellRef F68 = CellRef.Parse("F68");
		public static readonly CellRef F74 = CellRef.Parse("F74");
		public static readonly CellRef F85 = CellRef.Parse("F85");
		public static readonly CellRef F86 = CellRef.Parse("F86");
		public static readonly CellRef F87 = CellRef.Parse("F87");
		public static readonly CellRef F88 = CellRef.Parse("F88");
		public static readonly CellRef I19 = CellRef.Parse("I19");
		public static readonly CellRef L141 = CellRef.Parse("L141");
		public static readonly CellRef X10 = CellRef.Parse("X10");
		public static readonly CellRef X141 = CellRef.Parse("X141");
		public static readonly CellRef X6 = CellRef.Parse("X6");
		public static readonly CellRef Y10 = CellRef.Parse("Y10");
		public static readonly CellRef Y111 = CellRef.Parse("Y111");
		public static readonly CellRef Y112 = CellRef.Parse("Y112");
		public static readonly CellRef Y113 = CellRef.Parse("Y113");
		public static readonly CellRef Y114 = CellRef.Parse("Y114");
		public static readonly CellRef Y115 = CellRef.Parse("Y115");
		public static readonly CellRef Y116 = CellRef.Parse("Y116");
		public static readonly CellRef Y117 = CellRef.Parse("Y117");
		public static readonly CellRef Y118 = CellRef.Parse("Y118");
		public static readonly CellRef Y119 = CellRef.Parse("Y119");
		public static readonly CellRef Y120 = CellRef.Parse("Y120");
		public static readonly CellRef Y121 = CellRef.Parse("Y121");
		public static readonly CellRef Y122 = CellRef.Parse("Y122");
		public static readonly CellRef Y123 = CellRef.Parse("Y123");
		public static readonly CellRef Y124 = CellRef.Parse("Y124");
		public static readonly CellRef Y125 = CellRef.Parse("Y125");
		public static readonly CellRef Y126 = CellRef.Parse("Y126");
		public static readonly CellRef Y127 = CellRef.Parse("Y127");
		public static readonly CellRef Y128 = CellRef.Parse("Y128");
		public static readonly CellRef Y129 = CellRef.Parse("Y129");
		public static readonly CellRef Y13 = CellRef.Parse("Y13");
		public static readonly CellRef Y130 = CellRef.Parse("Y130");
		public static readonly CellRef Y131 = CellRef.Parse("Y131");
		public static readonly CellRef Y132 = CellRef.Parse("Y132");
		public static readonly CellRef Y133 = CellRef.Parse("Y133");
		public static readonly CellRef Y134 = CellRef.Parse("Y134");
		public static readonly CellRef Y135 = CellRef.Parse("Y135");
		public static readonly CellRef Y136 = CellRef.Parse("Y136");
		public static readonly CellRef Y137 = CellRef.Parse("Y137");
		public static readonly CellRef Y138 = CellRef.Parse("Y138");
		public static readonly CellRef Y139 = CellRef.Parse("Y139");
		public static readonly CellRef Y140 = CellRef.Parse("Y140");
		public static readonly CellRef Y141 = CellRef.Parse("Y141");
		public static readonly CellRef Y15 = CellRef.Parse("Y15");
		public static readonly CellRef Y6 = CellRef.Parse("Y6");
		public static readonly CellRef Y8 = CellRef.Parse("Y8");
		public static readonly CellRef Y80 = CellRef.Parse("Y80");
		public static readonly CellRef Z141 = CellRef.Parse("Z141");
		public static readonly CellRef Z15 = CellRef.Parse("Z15");
		public static readonly CellRef Z6 = CellRef.Parse("Z6");
		public static readonly CellRef Z8 = CellRef.Parse("Z8");
	}
}
