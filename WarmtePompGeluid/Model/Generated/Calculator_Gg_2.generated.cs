using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Ambacht.Common.Excel;

namespace WarmtePompGeluid.Model.Generated;

public class Calculator_Gg_2 : ExcelCalculatorBase {

	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? C85 {
		get => (double?)this[Addresses.C85];
		set => this[Addresses.C85] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? C86 {
		get => (double?)this[Addresses.C86];
		set => this[Addresses.C86] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? C87 {
		get => (double?)this[Addresses.C87];
		set => this[Addresses.C87] = value;
	}


	/// <summary>
	/// C85+C86-C87
	/// </summary>
	public object C88 => Subtract(Add(C85, C86), C87);


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? F85 {
		get => (double?)this[Addresses.F85];
		set => this[Addresses.F85] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? F86 {
		get => (double?)this[Addresses.F86];
		set => this[Addresses.F86] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? F87 {
		get => (double?)this[Addresses.F87];
		set => this[Addresses.F87] = value;
	}


	/// <summary>
	/// F85+F86-F87
	/// </summary>
	public object F88 => Subtract(Add(F85, F86), F87);


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B16 {
		get => (double?)this[Addresses.B16];
		set => this[Addresses.B16] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? C33 {
		get => (double?)this[Addresses.C33];
		set => this[Addresses.C33] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B15 {
		get => (double?)this[Addresses.B15];
		set => this[Addresses.B15] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B11 {
		get => (double?)this[Addresses.B11];
		set => this[Addresses.B11] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B12 {
		get => (double?)this[Addresses.B12];
		set => this[Addresses.B12] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? C34 {
		get => (double?)this[Addresses.C34];
		set => this[Addresses.C34] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B13 {
		get => (double?)this[Addresses.B13];
		set => this[Addresses.B13] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? C35 {
		get => (double?)this[Addresses.C35];
		set => this[Addresses.C35] = value;
	}


	/// <summary>
	/// SQRT(((B11-C33)^2)+((B12-C34)^2)+((B13-C35)^2))
	/// </summary>
	public object C54 => SQRT(Add(Add((Pow((Subtract(B11, C33)), 2)), (Pow((Subtract(B12, C34)), 2))), (Pow((Subtract(B13, C35)), 2))));


	/// <summary>
	/// variable (String)
	/// </summary>
	public string C36 {
		get => (string)this[Addresses.C36];
		set => this[Addresses.C36] = value;
	}


	/// <summary>
	/// IF(C36="J",5,0)
	/// </summary>
	public object C55 => IF(object.Equals(C36, "J"), 5, 0);


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? C37 {
		get => (double?)this[Addresses.C37];
		set => this[Addresses.C37] = value;
	}


	/// <summary>
	/// 10*LOG10(2/C37)
	/// </summary>
	public object C56 => Multiply(10, LOG10(Divide(2, C37)));


	/// <summary>
	/// IF((C33<>"nvt"),(20*LOG10(C54)+9+C55-C56),9999)
	/// </summary>
	public object C57 => IF((!object.Equals(C33, "nvt")), (Subtract(Add(Add(Multiply(20, LOG10(C54)), 9), C55), C56)), 9999);


	/// <summary>
	/// IF(C33<>"nvt",ROUND((45+C57),0),"")
	/// </summary>
	public object C62 => IF(!object.Equals(C33, "nvt"), ROUND((Add(45, C57)), 0), "");


	/// <summary>
	/// IF(C62<>"",-C62,-9999)
	/// </summary>
	public object C65 => IF(!object.Equals(C62, ""), Negate(C62), Negate(9999));


	/// <summary>
	/// variable (Blank)
	/// </summary>
	public object EA18 {
		get => this[Addresses.EA18];
		set => this[Addresses.EA18] = value;
	}


	/// <summary>
	/// variable (String)
	/// </summary>
	public string I22 {
		get => (string)this[Addresses.I22];
		set => this[Addresses.I22] = value;
	}


	/// <summary>
	/// IF(I22="J",1,0)
	/// </summary>
	public object L141 => IF(object.Equals(I22, "J"), 1, 0);


	/// <summary>
	/// B15
	/// </summary>
	public object AC10 => B15;


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B50 {
		get => (double?)this[Addresses.B50];
		set => this[Addresses.B50] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B28 {
		get => (double?)this[Addresses.B28];
		set => this[Addresses.B28] = value;
	}


	/// <summary>
	/// B28
	/// </summary>
	public object Y8 => B28;


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B21 {
		get => (double?)this[Addresses.B21];
		set => this[Addresses.B21] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B22 {
		get => (double?)this[Addresses.B22];
		set => this[Addresses.B22] = value;
	}


	/// <summary>
	/// +MAX(B21,B22)
	/// </summary>
	public object Y15 => Plus(MAX(B21, B22));


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B30 {
		get => (double?)this[Addresses.B30];
		set => this[Addresses.B30] = value;
	}


	/// <summary>
	/// +B30
	/// </summary>
	public object AB8 => Plus(B30);


	/// <summary>
	/// -AB8
	/// </summary>
	public object Z8 => Negate(AB8);


	/// <summary>
	/// B11
	/// </summary>
	public object X6 => B11;


	/// <summary>
	/// +Y15
	/// </summary>
	public object X141 => Plus(Y15);


	/// <summary>
	/// B12
	/// </summary>
	public object Y6 => B12;


	/// <summary>
	/// B13
	/// </summary>
	public object Z6 => B13;


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? BT141 {
		get => (double?)this[Addresses.BT141];
		set => this[Addresses.BT141] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B18 {
		get => (double?)this[Addresses.B18];
		set => this[Addresses.B18] = value;
	}


	/// <summary>
	/// B18
	/// </summary>
	public object X10 => B18;


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B19 {
		get => (double?)this[Addresses.B19];
		set => this[Addresses.B19] = value;
	}


	/// <summary>
	/// B19
	/// </summary>
	public object Y10 => B19;


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? DS141 {
		get => (double?)this[Addresses.DS141];
		set => this[Addresses.DS141] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B23 {
		get => (double?)this[Addresses.B23];
		set => this[Addresses.B23] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B24 {
		get => (double?)this[Addresses.B24];
		set => this[Addresses.B24] = value;
	}


	/// <summary>
	/// +MAX(B23,B24)
	/// </summary>
	public object AB15 => Plus(MAX(B23, B24));


	/// <summary>
	/// +MIN(B23,B24)
	/// </summary>
	public object Z15 => Plus(MIN(B23, B24));


	/// <summary>
	/// +(AB15-Z15)/30
	/// </summary>
	public object Y13 => Divide(Plus((Subtract(AB15, Z15))), 30);


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B25 {
		get => (double?)this[Addresses.B25];
		set => this[Addresses.B25] = value;
	}


	/// <summary>
	/// +B25
	/// </summary>
	public object AC15 => Plus(B25);


	/// <summary>
	/// +AC15
	/// </summary>
	public object Z141 => Plus(AC15);


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B66 {
		get => (double?)this[Addresses.B66];
		set => this[Addresses.B66] = value;
	}


	/// <summary>
	/// B66
	/// </summary>
	public object AC11 => B66;


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B31 {
		get => (double?)this[Addresses.B31];
		set => this[Addresses.B31] = value;
	}


	/// <summary>
	/// +B31
	/// </summary>
	public object AC8 => Plus(B31);


	/// <summary>
	/// +AC8
	/// </summary>
	public object AK141 => Plus(AC8);


	/// <summary>
	/// +AK141
	/// </summary>
	public object BS141 => Plus(AK141);


	/// <summary>
	/// IF(((BS141-BT141)*(AC11/(2^(1/3)))/250)<1,((BS141-BT141)*(AC11/(2^(1/3)))/250),1)
	/// </summary>
	public object BU141 => IF(Less((Divide(Multiply((Subtract(BS141, BT141)), (Divide(AC11, (Pow(2, (Divide(1, 3))))))), 250)), 1), (Divide(Multiply((Subtract(BS141, BT141)), (Divide(AC11, (Pow(2, (Divide(1, 3))))))), 250)), 1);


	/// <summary>
	/// +AC8
	/// </summary>
	public object CL141 => Plus(AC8);


	/// <summary>
	/// +CL141
	/// </summary>
	public object DR141 => Plus(CL141);


	/// <summary>
	/// IF(((DR141-DS141)*(AC11/(2^(1/3)))/250)<1,(DR141-DS141)*(AC11/(2^(1/3)))/250,1)
	/// </summary>
	public object DT141 => IF(Less((Divide(Multiply((Subtract(DR141, DS141)), (Divide(AC11, (Pow(2, (Divide(1, 3))))))), 250)), 1), Divide(Multiply((Subtract(DR141, DS141)), (Divide(AC11, (Pow(2, (Divide(1, 3))))))), 250), 1);


	/// <summary>
	/// B11-X141
	/// </summary>
	public object AT141 => Subtract(B11, X141);


	/// <summary>
	/// B11-X141
	/// </summary>
	public object CU141 => Subtract(B11, X141);


	/// <summary>
	/// +Z15
	/// </summary>
	public object Y80 => Plus(Z15);


	/// <summary>
	/// +Y80
	/// </summary>
	public object Y111 => Plus(Y80);


	/// <summary>
	/// +Y111+Y13
	/// </summary>
	public object Y112 => Add(Plus(Y111), Y13);


	/// <summary>
	/// +Y112+Y13
	/// </summary>
	public object Y113 => Add(Plus(Y112), Y13);


	/// <summary>
	/// +Y113+Y13
	/// </summary>
	public object Y114 => Add(Plus(Y113), Y13);


	/// <summary>
	/// +Y114+Y13
	/// </summary>
	public object Y115 => Add(Plus(Y114), Y13);


	/// <summary>
	/// +Y115+Y13
	/// </summary>
	public object Y116 => Add(Plus(Y115), Y13);


	/// <summary>
	/// +Y116+Y13
	/// </summary>
	public object Y117 => Add(Plus(Y116), Y13);


	/// <summary>
	/// +Y117+Y13
	/// </summary>
	public object Y118 => Add(Plus(Y117), Y13);


	/// <summary>
	/// +Y118+Y13
	/// </summary>
	public object Y119 => Add(Plus(Y118), Y13);


	/// <summary>
	/// +Y119+Y13
	/// </summary>
	public object Y120 => Add(Plus(Y119), Y13);


	/// <summary>
	/// +Y120+Y13
	/// </summary>
	public object Y121 => Add(Plus(Y120), Y13);


	/// <summary>
	/// +Y121+Y13
	/// </summary>
	public object Y122 => Add(Plus(Y121), Y13);


	/// <summary>
	/// +Y122+Y13
	/// </summary>
	public object Y123 => Add(Plus(Y122), Y13);


	/// <summary>
	/// +Y123+Y13
	/// </summary>
	public object Y124 => Add(Plus(Y123), Y13);


	/// <summary>
	/// +Y124+Y13
	/// </summary>
	public object Y125 => Add(Plus(Y124), Y13);


	/// <summary>
	/// +Y125+Y13
	/// </summary>
	public object Y126 => Add(Plus(Y125), Y13);


	/// <summary>
	/// +Y126+Y13
	/// </summary>
	public object Y127 => Add(Plus(Y126), Y13);


	/// <summary>
	/// +Y127+Y13
	/// </summary>
	public object Y128 => Add(Plus(Y127), Y13);


	/// <summary>
	/// +Y128+Y13
	/// </summary>
	public object Y129 => Add(Plus(Y128), Y13);


	/// <summary>
	/// +Y129+Y13
	/// </summary>
	public object Y130 => Add(Plus(Y129), Y13);


	/// <summary>
	/// +Y130+Y13
	/// </summary>
	public object Y131 => Add(Plus(Y130), Y13);


	/// <summary>
	/// +Y131+Y13
	/// </summary>
	public object Y132 => Add(Plus(Y131), Y13);


	/// <summary>
	/// +Y132+Y13
	/// </summary>
	public object Y133 => Add(Plus(Y132), Y13);


	/// <summary>
	/// +Y133+Y13
	/// </summary>
	public object Y134 => Add(Plus(Y133), Y13);


	/// <summary>
	/// +Y134+Y13
	/// </summary>
	public object Y135 => Add(Plus(Y134), Y13);


	/// <summary>
	/// +Y135+Y13
	/// </summary>
	public object Y136 => Add(Plus(Y135), Y13);


	/// <summary>
	/// +Y136+Y13
	/// </summary>
	public object Y137 => Add(Plus(Y136), Y13);


	/// <summary>
	/// +Y137+Y13
	/// </summary>
	public object Y138 => Add(Plus(Y137), Y13);


	/// <summary>
	/// +Y138+Y13
	/// </summary>
	public object Y139 => Add(Plus(Y138), Y13);


	/// <summary>
	/// +Y139+Y13
	/// </summary>
	public object Y140 => Add(Plus(Y139), Y13);


	/// <summary>
	/// +Y140+Y13
	/// </summary>
	public object Y141 => Add(Plus(Y140), Y13);


	/// <summary>
	/// IF(Y8>=Y15,IF(Y141<=AB8,IF(Y141>Z8,1,0),0),0)
	/// </summary>
	public object DX141 => IF(GreaterOrEqual(Y8, Y15), IF(LessOrEqual(Y141, AB8), IF(Greater(Y141, Z8), 1, 0), 0), 0);


	/// <summary>
	/// +SQRT(((X6-X141)^2)+((Y141-Y6)^2)+((Z141-Z6)^2))
	/// </summary>
	public object BY141 => Plus(SQRT(Add(Add((Pow((Subtract(X6, X141)), 2)), (Pow((Subtract(Y141, Y6)), 2))), (Pow((Subtract(Z141, Z6)), 2)))));


	/// <summary>
	/// +SQRT(((X6-X141)^2)+((Y141+Y6)^2)+((Z141-Z6)^2))
	/// </summary>
	public object DY141 => Plus(SQRT(Add(Add((Pow((Subtract(X6, X141)), 2)), (Pow((Add(Y141, Y6)), 2))), (Pow((Subtract(Z141, Z6)), 2)))));


	/// <summary>
	/// X6+(Y6*(X141-X6)/(Y141+Y6))
	/// </summary>
	public object CA141 => Add(X6, (Divide(Multiply(Y6, (Subtract(X141, X6))), (Add(Y141, Y6)))));


	/// <summary>
	/// IF(CA141>=X10,IF(CA141<=Y10,1,""),"")
	/// </summary>
	public object CB141 => IF(GreaterOrEqual(CA141, X10), IF(LessOrEqual(CA141, Y10), 1, ""), "");


	/// <summary>
	/// +Y6+((Y141-Y6)*(Y8-X6)/(X141-X6))
	/// </summary>
	public object AC141 => Add(Plus(Y6), (Divide(Multiply((Subtract(Y141, Y6)), (Subtract(Y8, X6))), (Subtract(X141, X6)))));


	/// <summary>
	/// IF(AC141<Z8,Z8,IF(AC141>AB8,AB8,AC141))
	/// </summary>
	public object AG141 => IF(Less(AC141, Z8), Z8, IF(Greater(AC141, AB8), AB8, AC141));


	/// <summary>
	/// IF((Y141-Y6)<>0,(+X6+((X141-X6)*(Z8-Y6)/(Y141-Y6))),-100000)
	/// </summary>
	public object AD141 => IF(!object.Equals((Subtract(Y141, Y6)), 0), (Add(Plus(X6), (Divide(Multiply((Subtract(X141, X6)), (Subtract(Z8, Y6))), (Subtract(Y141, Y6)))))), Negate(100000));


	/// <summary>
	/// IF((Y141-Y6)<>0,(+X6+((X141-X6)*(AB8-Y6)/(Y141-Y6))),100000)
	/// </summary>
	public object AE141 => IF(!object.Equals((Subtract(Y141, Y6)), 0), (Add(Plus(X6), (Divide(Multiply((Subtract(X141, X6)), (Subtract(AB8, Y6))), (Subtract(Y141, Y6)))))), 100000);


	/// <summary>
	/// IF(AC141<Z8,AD141,IF(AC141>AB8,AE141,Y8))
	/// </summary>
	public object AF141 => IF(Less(AC141, Z8), AD141, IF(Greater(AC141, AB8), AE141, Y8));


	/// <summary>
	/// +SQRT(((AF141-X6)^2)+((Y6-AG141)^2))
	/// </summary>
	public object AH141 => Plus(SQRT(Add((Pow((Subtract(AF141, X6)), 2)), (Pow((Subtract(Y6, AG141)), 2)))));


	/// <summary>
	/// +SQRT((AH141^2)+((AK141-Z6)^2))
	/// </summary>
	public object AL141 => Plus(SQRT(Add((Pow(AH141, 2)), (Pow((Subtract(AK141, Z6)), 2)))));


	/// <summary>
	/// +SQRT(((X141-AF141)^2)+((Y141-AG141)^2))
	/// </summary>
	public object AI141 => Plus(SQRT(Add((Pow((Subtract(X141, AF141)), 2)), (Pow((Subtract(Y141, AG141)), 2)))));


	/// <summary>
	/// +Z6+((Z141-Z6)*AH141/(AH141+AI141))
	/// </summary>
	public object AJ141 => Add(Plus(Z6), (Divide(Multiply((Subtract(Z141, Z6)), AH141), (Add(AH141, AI141)))));


	/// <summary>
	/// +SQRT(AI141^2+((AK141-Z141)^2))
	/// </summary>
	public object AM141 => Plus(SQRT(Pow(AI141, Add(2, (Pow((Subtract(AK141, Z141)), 2))))));


	/// <summary>
	/// +SQRT(AH141^2+((AJ141-Z6)^2))
	/// </summary>
	public object AN141 => Plus(SQRT(Pow(AH141, Add(2, (Pow((Subtract(AJ141, Z6)), 2))))));


	/// <summary>
	/// +SQRT((AI141^2)+((AJ141-Z141)^2))
	/// </summary>
	public object AO141 => Plus(SQRT(Add((Pow(AI141, 2)), (Pow((Subtract(AJ141, Z141)), 2)))));


	/// <summary>
	/// +IF(AK141>AJ141,(AL141+AM141-AN141-AO141),(AN141+AO141-AL141-AM141))
	/// </summary>
	public object AR141 => Plus(IF(Greater(AK141, AJ141), (Subtract(Subtract(Add(AL141, AM141), AN141), AO141)), (Subtract(Subtract(Add(AN141, AO141), AL141), AM141))));


	/// <summary>
	/// 0.0059*AR141*(AC11/(2^(1/3)))
	/// </summary>
	public object AS141 => Multiply(Multiply(59, AR141), (Divide(AC11, (Pow(2, (Divide(1, 3)))))));


	/// <summary>
	/// B12-Y141
	/// </summary>
	public object AU141 => Subtract(B12, Y141);


	/// <summary>
	/// -((AT141^2)+(AU141^2))/(B13-Z141)
	/// </summary>
	public object AV141 => Divide(Negate((Add((Pow(AT141, 2)), (Pow(AU141, 2))))), (Subtract(B13, Z141)));


	/// <summary>
	/// SQRT((AT141^2)+(AU141^2)+(AV141^2))
	/// </summary>
	public object AW141 => SQRT(Add(Add((Pow(AT141, 2)), (Pow(AU141, 2))), (Pow(AV141, 2))));


	/// <summary>
	/// AT141/AW141
	/// </summary>
	public object AX141 => Divide(AT141, AW141);


	/// <summary>
	/// AU141/AW141
	/// </summary>
	public object AY141 => Divide(AU141, AW141);


	/// <summary>
	/// AV141/AW141
	/// </summary>
	public object AZ141 => Divide(AV141, AW141);


	/// <summary>
	/// -((AX141*B11)+(AY141*B12)+(AZ141*B13))
	/// </summary>
	public object BA141 => Negate((Add(Add((Multiply(AX141, B11)), (Multiply(AY141, B12))), (Multiply(AZ141, B13)))));


	/// <summary>
	/// IF(AX141<>0,(-(BA141+(AY141*Z8)+(AZ141*AC8))/AX141),1000)
	/// </summary>
	public object BD141 => IF(!object.Equals(AX141, 0), (Divide(Negate((Add(Add(BA141, (Multiply(AY141, Z8))), (Multiply(AZ141, AC8))))), AX141)), 1000);


	/// <summary>
	/// ((((X6-BD141)^2)+((Y6-Z8)^2)+((Z6-AC8)^2))^0.5)+((((BD141-X141)^2)+((Z8-Y141)^2)+((AC8-Z141)^2))^0.5)-BY141
	/// </summary>
	public object BJ141 => Subtract(Add((Pow((Add(Add((Pow((Subtract(X6, BD141)), 2)), (Pow((Subtract(Y6, Z8)), 2))), (Pow((Subtract(Z6, AC8)), 2)))), 5)), (Pow((Add(Add((Pow((Subtract(BD141, X141)), 2)), (Pow((Subtract(Z8, Y141)), 2))), (Pow((Subtract(AC8, Z141)), 2)))), 5))), BY141);


	/// <summary>
	/// IF(AX141<>0,(-(BA141+(AY141*B30)+(AZ141*B31))/AX141),1000)
	/// </summary>
	public object BE141 => IF(!object.Equals(AX141, 0), (Divide(Negate((Add(Add(BA141, (Multiply(AY141, B30))), (Multiply(AZ141, B31))))), AX141)), 1000);


	/// <summary>
	/// ((((X6-BE141)^2)+((Y6-AB8)^2)+((Z6-AC8)^2))^0.5)+((((BE141-X141)^2)+((AB8-Y141)^2)+((AC8-Z141)^2))^0.5)-BY141
	/// </summary>
	public object BM141 => Subtract(Add((Pow((Add(Add((Pow((Subtract(X6, BE141)), 2)), (Pow((Subtract(Y6, AB8)), 2))), (Pow((Subtract(Z6, AC8)), 2)))), 5)), (Pow((Add(Add((Pow((Subtract(BE141, X141)), 2)), (Pow((Subtract(AB8, Y141)), 2))), (Pow((Subtract(AC8, Z141)), 2)))), 5))), BY141);


	/// <summary>
	/// MIN(BJ141:BM141)
	/// </summary>
	public object BQ141 => MIN((Addresses.BJ141, Addresses.BM141));


	/// <summary>
	/// 0.0059*BQ141*(AC11/(2^(1/3)))
	/// </summary>
	public object BR141 => Multiply(Multiply(59, BQ141), (Divide(AC11, (Pow(2, (Divide(1, 3)))))));


	/// <summary>
	/// +IF(AS141>(-0.1),(10*BU141*LOG10(1/((1/(20*AS141+3))+(1/(20*BR141+3))))),0)
	/// </summary>
	public object BW141 => Plus(IF(Greater(AS141, (Negate(1))), (Multiply(Multiply(10, BU141), LOG10(Divide(1, (Add((Divide(1, (Add(Multiply(20, AS141), 3)))), (Divide(1, (Add(Multiply(20, BR141), 3)))))))))), 0));


	/// <summary>
	/// +AC10-(10*LOG10(PI()*2*(BY141^2)))-BW141-1
	/// </summary>
	public object BZ141 => Subtract(Subtract(Subtract(Plus(AC10), (Multiply(10, LOG10(Multiply(Multiply(PI(), 2), (Pow(BY141, 2))))))), BW141), 1);


	/// <summary>
	/// +Y6+((Y141-Y6)*(Y8-X6)/(X141-X6))
	/// </summary>
	public object CD141 => Add(Plus(Y6), (Divide(Multiply((Subtract(Y141, Y6)), (Subtract(Y8, X6))), (Subtract(X141, X6)))));


	/// <summary>
	/// IF(CD141<Z8,Z8,IF(CD141>AB8,AB8,CD141))
	/// </summary>
	public object CH141 => IF(Less(CD141, Z8), Z8, IF(Greater(CD141, AB8), AB8, CD141));


	/// <summary>
	/// IF((Y141-Y6)<>0,(+X6+((X141-X6)*(Z8-Y6)/(Y141-Y6))),-100000)
	/// </summary>
	public object CE141 => IF(!object.Equals((Subtract(Y141, Y6)), 0), (Add(Plus(X6), (Divide(Multiply((Subtract(X141, X6)), (Subtract(Z8, Y6))), (Subtract(Y141, Y6)))))), Negate(100000));


	/// <summary>
	/// IF((Y141-Y6)<>0,(+X6+((X141-X6)*(AB8-Y6)/(Y141-Y6))),100000)
	/// </summary>
	public object CF141 => IF(!object.Equals((Subtract(Y141, Y6)), 0), (Add(Plus(X6), (Divide(Multiply((Subtract(X141, X6)), (Subtract(AB8, Y6))), (Subtract(Y141, Y6)))))), 100000);


	/// <summary>
	/// IF(CD141<Z8,CE141,IF(CD141>AB8,CF141,Y8))
	/// </summary>
	public object CG141 => IF(Less(CD141, Z8), CE141, IF(Greater(CD141, AB8), CF141, Y8));


	/// <summary>
	/// +SQRT(((CG141-X6)^2)+((-Y6-CH141)^2))
	/// </summary>
	public object CI141 => Plus(SQRT(Add((Pow((Subtract(CG141, X6)), 2)), (Pow((Subtract(Negate(Y6), CH141)), 2)))));


	/// <summary>
	/// +SQRT(CI141^2+((CL141-Z6)^2))
	/// </summary>
	public object CM141 => Plus(SQRT(Pow(CI141, Add(2, (Pow((Subtract(CL141, Z6)), 2))))));


	/// <summary>
	/// +SQRT(((X141-CG141)^2)+((Y141-CH141)^2))
	/// </summary>
	public object CJ141 => Plus(SQRT(Add((Pow((Subtract(X141, CG141)), 2)), (Pow((Subtract(Y141, CH141)), 2)))));


	/// <summary>
	/// +Z6+((Z141-Z6)*CI141/(CI141+CJ141))
	/// </summary>
	public object CK141 => Add(Plus(Z6), (Divide(Multiply((Subtract(Z141, Z6)), CI141), (Add(CI141, CJ141)))));


	/// <summary>
	/// +SQRT(CJ141^2+((CL141-Z141)^2))
	/// </summary>
	public object CN141 => Plus(SQRT(Pow(CJ141, Add(2, (Pow((Subtract(CL141, Z141)), 2))))));


	/// <summary>
	/// +SQRT(CI141^2+((CK141-Z6)^2))
	/// </summary>
	public object CO141 => Plus(SQRT(Pow(CI141, Add(2, (Pow((Subtract(CK141, Z6)), 2))))));


	/// <summary>
	/// +SQRT(CJ141^2+((CK141-Z141)^2))
	/// </summary>
	public object CP141 => Plus(SQRT(Pow(CJ141, Add(2, (Pow((Subtract(CK141, Z141)), 2))))));


	/// <summary>
	/// +IF(CL141>CK141,(CM141+CN141-CO141-CP141),(CO141+CP141-CM141-CN141))
	/// </summary>
	public object CS141 => Plus(IF(Greater(CL141, CK141), (Subtract(Subtract(Add(CM141, CN141), CO141), CP141)), (Subtract(Subtract(Add(CO141, CP141), CM141), CN141))));


	/// <summary>
	/// 0.0059*CS141*(AC11/(2^(1/3)))
	/// </summary>
	public object CT141 => Multiply(Multiply(59, CS141), (Divide(AC11, (Pow(2, (Divide(1, 3)))))));


	/// <summary>
	/// B12-Y141
	/// </summary>
	public object CV141 => Subtract(B12, Y141);


	/// <summary>
	/// -((CU141^2)+(CV141^2))/(B13-Z141)
	/// </summary>
	public object CW141 => Divide(Negate((Add((Pow(CU141, 2)), (Pow(CV141, 2))))), (Subtract(B13, Z141)));


	/// <summary>
	/// SQRT(CU141^2+(CV141^2)+(CW141^2))
	/// </summary>
	public object CX141 => SQRT(Pow(CU141, Add(Add(2, (Pow(CV141, 2))), (Pow(CW141, 2)))));


	/// <summary>
	/// CU141/CX141
	/// </summary>
	public object CY141 => Divide(CU141, CX141);


	/// <summary>
	/// CV141/CX141
	/// </summary>
	public object CZ141 => Divide(CV141, CX141);


	/// <summary>
	/// CW141/CX141
	/// </summary>
	public object DA141 => Divide(CW141, CX141);


	/// <summary>
	/// -(CY141*B11+(CZ141*B12)+(DA141*B13))
	/// </summary>
	public object DB141 => Negate((Add(Add(Multiply(CY141, B11), (Multiply(CZ141, B12))), (Multiply(DA141, B13)))));


	/// <summary>
	/// IF(CY141<>0,(-(DB141+(CZ141*Z8)+(DA141*AC8))/CY141),1000)
	/// </summary>
	public object DE141 => IF(!object.Equals(CY141, 0), (Divide(Negate((Add(Add(DB141, (Multiply(CZ141, Z8))), (Multiply(DA141, AC8))))), CY141)), 1000);


	/// <summary>
	/// ((((X6-DE141)^2)+((-Y6-Z8)^2)+((Z6-AC8)^2))^0.5)+((((DE141-X141)^2)+((Z8-Y141)^2)+((AC8-Z141)^2))^0.5)-BY141
	/// </summary>
	public object DL141 => Subtract(Add((Pow((Add(Add((Pow((Subtract(X6, DE141)), 2)), (Pow((Subtract(Negate(Y6), Z8)), 2))), (Pow((Subtract(Z6, AC8)), 2)))), 5)), (Pow((Add(Add((Pow((Subtract(DE141, X141)), 2)), (Pow((Subtract(Z8, Y141)), 2))), (Pow((Subtract(AC8, Z141)), 2)))), 5))), BY141);


	/// <summary>
	/// IF(CY141<>0,(-(DB141+(CZ141*B30)+(DA141*B31))/CY141),1000)
	/// </summary>
	public object DF141 => IF(!object.Equals(CY141, 0), (Divide(Negate((Add(Add(DB141, (Multiply(CZ141, B30))), (Multiply(DA141, B31))))), CY141)), 1000);


	/// <summary>
	/// ((((X6-DF141)^2)+((-Y6-Z8)^2)+((Z6-AC8)^2))^0.5)+((((DF141-X141)^2)+((Z8-Y141)^2)+((AC8-Z141)^2))^0.5)-BY141
	/// </summary>
	public object DO141 => Subtract(Add((Pow((Add(Add((Pow((Subtract(X6, DF141)), 2)), (Pow((Subtract(Negate(Y6), Z8)), 2))), (Pow((Subtract(Z6, AC8)), 2)))), 5)), (Pow((Add(Add((Pow((Subtract(DF141, X141)), 2)), (Pow((Subtract(Z8, Y141)), 2))), (Pow((Subtract(AC8, Z141)), 2)))), 5))), BY141);


	/// <summary>
	/// MIN(DL141:DO141)
	/// </summary>
	public object DP141 => MIN((Addresses.DL141, Addresses.DO141));


	/// <summary>
	/// 0.0059*DP141*(AC11/(2^(1/3)))
	/// </summary>
	public object DQ141 => Multiply(Multiply(59, DP141), (Divide(AC11, (Pow(2, (Divide(1, 3)))))));


	/// <summary>
	/// +IF(CT141>(-0.1),(10*DT141*LOG10(1/((1/(20*CT141+3))+(1/(20*DQ141+3))))),0)
	/// </summary>
	public object DV141 => Plus(IF(Greater(CT141, (Negate(1))), (Multiply(Multiply(10, DT141), LOG10(Divide(1, (Add((Divide(1, (Add(Multiply(20, CT141), 3)))), (Divide(1, (Add(Multiply(20, DQ141), 3)))))))))), 0));


	/// <summary>
	/// IF((CB141=1),IF((B50<1),(+AC10-(10*LOG10(PI()*2*(DY141^2)))-DV141-1+(10*LOG10(1-B50))),-9999),-9999)
	/// </summary>
	public object DZ141 => IF((object.Equals(CB141, 1)), IF((Less(B50, 1)), (Add(Subtract(Subtract(Subtract(Plus(AC10), (Multiply(10, LOG10(Multiply(Multiply(PI(), 2), (Pow(DY141, 2))))))), DV141), 1), (Multiply(10, LOG10(Subtract(1, B50)))))), Negate(9999)), Negate(9999));


	/// <summary>
	/// IF(L141=1,IF(DX141=0,ROUND(10*LOG10((10^(BZ141/10))+(10^(DZ141/10))),0),""),"")
	/// </summary>
	public object EA141 => IF(object.Equals(L141, 1), IF(object.Equals(DX141, 0), ROUND(Multiply(10, LOG10(Add((Pow(10, (Divide(BZ141, 10)))), (Pow(10, (Divide(DZ141, 10))))))), 0), ""), "");


	/// <summary>
	/// MAX(EA18:EA141)
	/// </summary>
	public object F58 => MAX((Addresses.EA18, Addresses.EA141));


	/// <summary>
	/// B15-F58
	/// </summary>
	public object F57 => Subtract(B15, F58);


	/// <summary>
	/// ROUND((45+F57),0)
	/// </summary>
	public object F62 => ROUND((Add(45, F57)), 0);


	/// <summary>
	/// IF(F62<>"",-F62,-9999)
	/// </summary>
	public object F65 => IF(!object.Equals(F62, ""), Negate(F62), Negate(9999));


	/// <summary>
	/// (-MAX(C65:F65))-B16
	/// </summary>
	public object C45 => Subtract((Negate(MAX((Addresses.C65, Addresses.F65)))), B16);


	/// <summary>
	/// ROUND(C45,0)
	/// </summary>
	public object C74 => ROUND(C45, 0);


	/// <summary>
	/// IF(C88<=C74,"VOLDOET","VOLDOET NIET")
	/// </summary>
	public object B89 => IF(LessOrEqual(C88, C74), "VOLDOET", "VOLDOET NIET");


	/// <summary>
	/// C45-5
	/// </summary>
	public object C46 => Subtract(C45, 5);


	/// <summary>
	/// ROUND(C46,0)
	/// </summary>
	public object F74 => ROUND(C46, 0);


	/// <summary>
	/// IF(F88<=F74,"VOLDOET","VOLDOET NIET")
	/// </summary>
	public object E89 => IF(LessOrEqual(F88, F74), "VOLDOET", "VOLDOET NIET");

	public static class Addresses
	{
		public static readonly (int, int) AB15 = new(14, 27);
		public static readonly (int, int) AB8 = new(7, 27);
		public static readonly (int, int) AC10 = new(9, 28);
		public static readonly (int, int) AC11 = new(10, 28);
		public static readonly (int, int) AC141 = new(140, 28);
		public static readonly (int, int) AC15 = new(14, 28);
		public static readonly (int, int) AC8 = new(7, 28);
		public static readonly (int, int) AD141 = new(140, 29);
		public static readonly (int, int) AE141 = new(140, 30);
		public static readonly (int, int) AF141 = new(140, 31);
		public static readonly (int, int) AG141 = new(140, 32);
		public static readonly (int, int) AH141 = new(140, 33);
		public static readonly (int, int) AI141 = new(140, 34);
		public static readonly (int, int) AJ141 = new(140, 35);
		public static readonly (int, int) AK141 = new(140, 36);
		public static readonly (int, int) AL141 = new(140, 37);
		public static readonly (int, int) AM141 = new(140, 38);
		public static readonly (int, int) AN141 = new(140, 39);
		public static readonly (int, int) AO141 = new(140, 40);
		public static readonly (int, int) AR141 = new(140, 43);
		public static readonly (int, int) AS141 = new(140, 44);
		public static readonly (int, int) AT141 = new(140, 45);
		public static readonly (int, int) AU141 = new(140, 46);
		public static readonly (int, int) AV141 = new(140, 47);
		public static readonly (int, int) AW141 = new(140, 48);
		public static readonly (int, int) AX141 = new(140, 49);
		public static readonly (int, int) AY141 = new(140, 50);
		public static readonly (int, int) AZ141 = new(140, 51);
		public static readonly (int, int) B11 = new(10, 1);
		public static readonly (int, int) B12 = new(11, 1);
		public static readonly (int, int) B13 = new(12, 1);
		public static readonly (int, int) B15 = new(14, 1);
		public static readonly (int, int) B16 = new(15, 1);
		public static readonly (int, int) B18 = new(17, 1);
		public static readonly (int, int) B19 = new(18, 1);
		public static readonly (int, int) B21 = new(20, 1);
		public static readonly (int, int) B22 = new(21, 1);
		public static readonly (int, int) B23 = new(22, 1);
		public static readonly (int, int) B24 = new(23, 1);
		public static readonly (int, int) B25 = new(24, 1);
		public static readonly (int, int) B28 = new(27, 1);
		public static readonly (int, int) B30 = new(29, 1);
		public static readonly (int, int) B31 = new(30, 1);
		public static readonly (int, int) B50 = new(49, 1);
		public static readonly (int, int) B66 = new(65, 1);
		public static readonly (int, int) BA141 = new(140, 52);
		public static readonly (int, int) BD141 = new(140, 55);
		public static readonly (int, int) BE141 = new(140, 56);
		public static readonly (int, int) BJ141 = new(140, 61);
		public static readonly (int, int) BM141 = new(140, 64);
		public static readonly (int, int) BQ141 = new(140, 68);
		public static readonly (int, int) BR141 = new(140, 69);
		public static readonly (int, int) BS141 = new(140, 70);
		public static readonly (int, int) BT141 = new(140, 71);
		public static readonly (int, int) BU141 = new(140, 72);
		public static readonly (int, int) BW141 = new(140, 74);
		public static readonly (int, int) BY141 = new(140, 76);
		public static readonly (int, int) BZ141 = new(140, 77);
		public static readonly (int, int) C33 = new(32, 2);
		public static readonly (int, int) C34 = new(33, 2);
		public static readonly (int, int) C35 = new(34, 2);
		public static readonly (int, int) C36 = new(35, 2);
		public static readonly (int, int) C37 = new(36, 2);
		public static readonly (int, int) C45 = new(44, 2);
		public static readonly (int, int) C46 = new(45, 2);
		public static readonly (int, int) C54 = new(53, 2);
		public static readonly (int, int) C55 = new(54, 2);
		public static readonly (int, int) C56 = new(55, 2);
		public static readonly (int, int) C57 = new(56, 2);
		public static readonly (int, int) C62 = new(61, 2);
		public static readonly (int, int) C65 = new(64, 2);
		public static readonly (int, int) C74 = new(73, 2);
		public static readonly (int, int) C85 = new(84, 2);
		public static readonly (int, int) C86 = new(85, 2);
		public static readonly (int, int) C87 = new(86, 2);
		public static readonly (int, int) C88 = new(87, 2);
		public static readonly (int, int) CA141 = new(140, 78);
		public static readonly (int, int) CB141 = new(140, 79);
		public static readonly (int, int) CD141 = new(140, 81);
		public static readonly (int, int) CE141 = new(140, 82);
		public static readonly (int, int) CF141 = new(140, 83);
		public static readonly (int, int) CG141 = new(140, 84);
		public static readonly (int, int) CH141 = new(140, 85);
		public static readonly (int, int) CI141 = new(140, 86);
		public static readonly (int, int) CJ141 = new(140, 87);
		public static readonly (int, int) CK141 = new(140, 88);
		public static readonly (int, int) CL141 = new(140, 89);
		public static readonly (int, int) CM141 = new(140, 90);
		public static readonly (int, int) CN141 = new(140, 91);
		public static readonly (int, int) CO141 = new(140, 92);
		public static readonly (int, int) CP141 = new(140, 93);
		public static readonly (int, int) CS141 = new(140, 96);
		public static readonly (int, int) CT141 = new(140, 97);
		public static readonly (int, int) CU141 = new(140, 98);
		public static readonly (int, int) CV141 = new(140, 99);
		public static readonly (int, int) CW141 = new(140, 100);
		public static readonly (int, int) CX141 = new(140, 101);
		public static readonly (int, int) CY141 = new(140, 102);
		public static readonly (int, int) CZ141 = new(140, 103);
		public static readonly (int, int) DA141 = new(140, 104);
		public static readonly (int, int) DB141 = new(140, 105);
		public static readonly (int, int) DE141 = new(140, 108);
		public static readonly (int, int) DF141 = new(140, 109);
		public static readonly (int, int) DL141 = new(140, 115);
		public static readonly (int, int) DO141 = new(140, 118);
		public static readonly (int, int) DP141 = new(140, 119);
		public static readonly (int, int) DQ141 = new(140, 120);
		public static readonly (int, int) DR141 = new(140, 121);
		public static readonly (int, int) DS141 = new(140, 122);
		public static readonly (int, int) DT141 = new(140, 123);
		public static readonly (int, int) DV141 = new(140, 125);
		public static readonly (int, int) DX141 = new(140, 127);
		public static readonly (int, int) DY141 = new(140, 128);
		public static readonly (int, int) DZ141 = new(140, 129);
		public static readonly (int, int) EA141 = new(140, 130);
		public static readonly (int, int) EA18 = new(17, 130);
		public static readonly (int, int) F57 = new(56, 5);
		public static readonly (int, int) F58 = new(57, 5);
		public static readonly (int, int) F62 = new(61, 5);
		public static readonly (int, int) F65 = new(64, 5);
		public static readonly (int, int) F74 = new(73, 5);
		public static readonly (int, int) F85 = new(84, 5);
		public static readonly (int, int) F86 = new(85, 5);
		public static readonly (int, int) F87 = new(86, 5);
		public static readonly (int, int) F88 = new(87, 5);
		public static readonly (int, int) I22 = new(21, 8);
		public static readonly (int, int) L141 = new(140, 11);
		public static readonly (int, int) X10 = new(9, 23);
		public static readonly (int, int) X141 = new(140, 23);
		public static readonly (int, int) X6 = new(5, 23);
		public static readonly (int, int) Y10 = new(9, 24);
		public static readonly (int, int) Y111 = new(110, 24);
		public static readonly (int, int) Y112 = new(111, 24);
		public static readonly (int, int) Y113 = new(112, 24);
		public static readonly (int, int) Y114 = new(113, 24);
		public static readonly (int, int) Y115 = new(114, 24);
		public static readonly (int, int) Y116 = new(115, 24);
		public static readonly (int, int) Y117 = new(116, 24);
		public static readonly (int, int) Y118 = new(117, 24);
		public static readonly (int, int) Y119 = new(118, 24);
		public static readonly (int, int) Y120 = new(119, 24);
		public static readonly (int, int) Y121 = new(120, 24);
		public static readonly (int, int) Y122 = new(121, 24);
		public static readonly (int, int) Y123 = new(122, 24);
		public static readonly (int, int) Y124 = new(123, 24);
		public static readonly (int, int) Y125 = new(124, 24);
		public static readonly (int, int) Y126 = new(125, 24);
		public static readonly (int, int) Y127 = new(126, 24);
		public static readonly (int, int) Y128 = new(127, 24);
		public static readonly (int, int) Y129 = new(128, 24);
		public static readonly (int, int) Y13 = new(12, 24);
		public static readonly (int, int) Y130 = new(129, 24);
		public static readonly (int, int) Y131 = new(130, 24);
		public static readonly (int, int) Y132 = new(131, 24);
		public static readonly (int, int) Y133 = new(132, 24);
		public static readonly (int, int) Y134 = new(133, 24);
		public static readonly (int, int) Y135 = new(134, 24);
		public static readonly (int, int) Y136 = new(135, 24);
		public static readonly (int, int) Y137 = new(136, 24);
		public static readonly (int, int) Y138 = new(137, 24);
		public static readonly (int, int) Y139 = new(138, 24);
		public static readonly (int, int) Y140 = new(139, 24);
		public static readonly (int, int) Y141 = new(140, 24);
		public static readonly (int, int) Y15 = new(14, 24);
		public static readonly (int, int) Y6 = new(5, 24);
		public static readonly (int, int) Y8 = new(7, 24);
		public static readonly (int, int) Y80 = new(79, 24);
		public static readonly (int, int) Z141 = new(140, 25);
		public static readonly (int, int) Z15 = new(14, 25);
		public static readonly (int, int) Z6 = new(5, 25);
		public static readonly (int, int) Z8 = new(7, 25);
	}
}
