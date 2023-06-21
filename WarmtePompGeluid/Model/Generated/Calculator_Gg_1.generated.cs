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
	public double? C35 {
		get => (double?)this[Addresses.C35];
		set => this[Addresses.C35] = value;
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
	public double? C36 {
		get => (double?)this[Addresses.C36];
		set => this[Addresses.C36] = value;
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
	public double? C37 {
		get => (double?)this[Addresses.C37];
		set => this[Addresses.C37] = value;
	}


	/// <summary>
	/// SQRT(((B11-C35)^2)+((B12-C36)^2)+((B13-C37)^2))
	/// </summary>
	public object C61 => SQRT(Add(Add((Pow((Subtract(B11, C35)), 2)), (Pow((Subtract(B12, C36)), 2))), (Pow((Subtract(B13, C37)), 2))));


	/// <summary>
	/// variable (String)
	/// </summary>
	public string C38 {
		get => (string)this[Addresses.C38];
		set => this[Addresses.C38] = value;
	}


	/// <summary>
	/// IF((C38="J"),5,0)
	/// </summary>
	public object C62 => IF((object.Equals(C38, "J")), 5, 0);


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? C39 {
		get => (double?)this[Addresses.C39];
		set => this[Addresses.C39] = value;
	}


	/// <summary>
	/// 10*LOG10(2/C39)
	/// </summary>
	public object C63 => Multiply(10, LOG10(Divide(2, C39)));


	/// <summary>
	/// 20*LOG10(C61)+9+C62-C63
	/// </summary>
	public object C64 => Subtract(Add(Add(Multiply(20, LOG10(C61)), 9), C62), C63);


	/// <summary>
	/// IF(C35="nvt","",ROUND(45+C64,0))
	/// </summary>
	public object C50 => IF(object.Equals(C35, "nvt"), "", ROUND(Add(45, C64), 0));


	/// <summary>
	/// IF(C50<>"",-C50,-9999)
	/// </summary>
	public object C52 => IF(!object.Equals(C50, ""), Negate(C50), Negate(9999));


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? C67 {
		get => (double?)this[Addresses.C67];
		set => this[Addresses.C67] = value;
	}


	/// <summary>
	/// variable (String)
	/// </summary>
	public string I21 {
		get => (string)this[Addresses.I21];
		set => this[Addresses.I21] = value;
	}


	/// <summary>
	/// IF(I21="j",1,0)
	/// </summary>
	public object L20 => IF(object.Equals(I21, "j"), 1, 0);


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B31 {
		get => (double?)this[Addresses.B31];
		set => this[Addresses.B31] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B32 {
		get => (double?)this[Addresses.B32];
		set => this[Addresses.B32] = value;
	}


	/// <summary>
	/// B15
	/// </summary>
	public object AB12 => B15;


	/// <summary>
	/// variable (String)
	/// </summary>
	public string I19 {
		get => (string)this[Addresses.I19];
		set => this[Addresses.I19] = value;
	}


	/// <summary>
	/// IF(I19="j",1,0)
	/// </summary>
	public object L112 => IF(object.Equals(I19, "j"), 1, 0);


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B29 {
		get => (double?)this[Addresses.B29];
		set => this[Addresses.B29] = value;
	}


	/// <summary>
	/// B11
	/// </summary>
	public object X7 => B11;


	/// <summary>
	/// B12
	/// </summary>
	public object Y7 => B12;


	/// <summary>
	/// B13
	/// </summary>
	public object Z7 => B13;


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B59 {
		get => (double?)this[Addresses.B59];
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
	public object BD20 => IF(object.Equals(BC20, 1), Add(Subtract(Subtract(AB12, (Multiply(20, LOG10(BB20)))), 9), (Multiply(10, LOG10(Subtract(1, B59))))), Negate(9999));


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B58 {
		get => (double?)this[Addresses.B58];
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
	public object AW112 => IF(object.Equals(AV112, 1), Add(Subtract(Subtract(AB12, (Multiply(20, LOG10(AU112)))), 9), (Multiply(10, LOG10(Subtract(1, B59))))), Negate(9999));


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B20 {
		get => (double?)this[Addresses.B20];
		set => this[Addresses.B20] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B21 {
		get => (double?)this[Addresses.B21];
		set => this[Addresses.B21] = value;
	}


	/// <summary>
	/// +MIN(B20,B21)
	/// </summary>
	public object Z17 => Plus(MIN(B20, B21));


	/// <summary>
	/// +Z17
	/// </summary>
	public object X20 => Plus(Z17);


	/// <summary>
	/// IF(X20>B31,IF(X20<B32,1,""),"")
	/// </summary>
	public object AI20 => IF(Greater(X20, B31), IF(Less(X20, B32), 1, ""), "");


	/// <summary>
	/// +MAX(B20,B21)
	/// </summary>
	public object AA17 => Plus(MAX(B20, B21));


	/// <summary>
	/// +AA17
	/// </summary>
	public object Y20 => Plus(AA17);


	/// <summary>
	/// +(AA17-Z17)/30
	/// </summary>
	public object Y15 => Divide(Plus((Subtract(AA17, Z17))), 30);


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B33 {
		get => (double?)this[Addresses.B33];
		set => this[Addresses.B33] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B27 {
		get => (double?)this[Addresses.B27];
		set => this[Addresses.B27] = value;
	}


	/// <summary>
	/// -X7
	/// </summary>
	public object AJ20 => Negate(X7);


	/// <summary>
	/// Y7
	/// </summary>
	public object AK20 => Y7;


	/// <summary>
	/// Y7
	/// </summary>
	public object AR20 => Y7;


	/// <summary>
	/// X7+(Y7*(X20-X7)/(Y20+Y7))
	/// </summary>
	public object AG20 => Add(X7, (Divide(Multiply(Y7, (Subtract(X20, X7))), (Add(Y20, Y7)))));


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B30 {
		get => (double?)this[Addresses.B30];
		set => this[Addresses.B30] = value;
	}


	/// <summary>
	/// -X7
	/// </summary>
	public object AJ112 => Negate(X7);


	/// <summary>
	/// Y7
	/// </summary>
	public object AK112 => Y7;


	/// <summary>
	/// X7
	/// </summary>
	public object AX112 => X7;


	/// <summary>
	/// 2*B21-Y7
	/// </summary>
	public object AY112 => Subtract(Multiply(2, B21), Y7);


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B22 {
		get => (double?)this[Addresses.B22];
		set => this[Addresses.B22] = value;
	}


	/// <summary>
	/// +B22
	/// </summary>
	public object AB17 => Plus(B22);


	/// <summary>
	/// IF(AI20<>1,AB17,B33+0.5)
	/// </summary>
	public object Z20 => IF(!object.Equals(AI20, 1), AB17, Add(B33, 5));


	/// <summary>
	/// +SQRT(((X7-X20)^2)+((Y20-Y7)^2)+((Z20-Z7)^2))
	/// </summary>
	public object AE20 => Plus(SQRT(Add(Add((Pow((Subtract(X7, X20)), 2)), (Pow((Subtract(Y20, Y7)), 2))), (Pow((Subtract(Z20, Z7)), 2)))));


	/// <summary>
	/// +AB12-(20*LOG10(AE20))-9
	/// </summary>
	public object AF20 => Subtract(Subtract(Plus(AB12), (Multiply(20, LOG10(AE20)))), 9);


	/// <summary>
	/// (((X20-AJ20)^2)+((Y20-AK20)^2)+((Z20-Z7)^2))^0.5
	/// </summary>
	public object AN20 => Pow((Add(Add((Pow((Subtract(X20, AJ20)), 2)), (Pow((Subtract(Y20, AK20)), 2))), (Pow((Subtract(Z20, Z7)), 2)))), 5);


	/// <summary>
	/// +SQRT(((X7-X20)^2)+((Y20+Y7)^2)+((Z20-Z7)^2))
	/// </summary>
	public object BE20 => Plus(SQRT(Add(Add((Pow((Subtract(X7, X20)), 2)), (Pow((Add(Y20, Y7)), 2))), (Pow((Subtract(Z20, Z7)), 2)))));


	/// <summary>
	/// X7/(X20+X7)
	/// </summary>
	public object AL20 => Divide(X7, (Add(X20, X7)));


	/// <summary>
	/// Y7+(AL20*(Y20-Y7))
	/// </summary>
	public object AM20 => Add(Y7, (Multiply(AL20, (Subtract(Y20, Y7)))));


	/// <summary>
	/// IF((AM20<=B27),1,0)
	/// </summary>
	public object AO20 => IF((LessOrEqual(AM20, B27)), 1, 0);


	/// <summary>
	/// IF((AO20=1),(AB12-(20*LOG10(AN20))-9+(10*LOG10(1-B59))),-9999)
	/// </summary>
	public object AP20 => IF((object.Equals(AO20, 1)), (Add(Subtract(Subtract(AB12, (Multiply(20, LOG10(AN20)))), 9), (Multiply(10, LOG10(Subtract(1, B59)))))), Negate(9999));


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B19 {
		get => (double?)this[Addresses.B19];
		set => this[Addresses.B19] = value;
	}


	/// <summary>
	/// 2*B19-B11
	/// </summary>
	public object AQ20 => Subtract(Multiply(2, B19), B11);


	/// <summary>
	/// (((AQ20-X20)^2)+((AR20-Y20)^2)+((Z20-Z7)^2))^0.5
	/// </summary>
	public object AU20 => Pow((Add(Add((Pow((Subtract(AQ20, X20)), 2)), (Pow((Subtract(AR20, Y20)), 2))), (Pow((Subtract(Z20, Z7)), 2)))), 5);


	/// <summary>
	/// (-B19+X7)/(2*B19-X7-X20)
	/// </summary>
	public object AS20 => Divide((Add(Negate(B19), X7)), (Subtract(Subtract(Multiply(2, B19), X7), X20)));


	/// <summary>
	/// Y7+(AS20*(Y7-Y20))
	/// </summary>
	public object AT20 => Add(Y7, (Multiply(AS20, (Subtract(Y7, Y20)))));


	/// <summary>
	/// IF(AT20<B29,1,0)
	/// </summary>
	public object AV20 => IF(Less(AT20, B29), 1, 0);


	/// <summary>
	/// IF(AV20=1,AB12-(20*LOG10(AU20))-9+(10*LOG10(1-B59)),-9999)
	/// </summary>
	public object AW20 => IF(object.Equals(AV20, 1), Add(Subtract(Subtract(AB12, (Multiply(20, LOG10(AU20)))), 9), (Multiply(10, LOG10(Subtract(1, B59))))), Negate(9999));


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B24 {
		get => (double?)this[Addresses.B24];
		set => this[Addresses.B24] = value;
	}


	/// <summary>
	/// B24
	/// </summary>
	public object X10 => B24;


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B25 {
		get => (double?)this[Addresses.B25];
		set => this[Addresses.B25] = value;
	}


	/// <summary>
	/// B25
	/// </summary>
	public object Y10 => B25;


	/// <summary>
	/// IF(AG20>=X10,IF(AG20<=Y10,1,""),"")
	/// </summary>
	public object AH20 => IF(GreaterOrEqual(AG20, X10), IF(LessOrEqual(AG20, Y10), 1, ""), "");


	/// <summary>
	/// IF((B58<1),IF((AH20=1),+AB12-(20*LOG10(BE20))-9+(10*LOG10(1-B58)),-999),-999)
	/// </summary>
	public object BF20 => IF((Less(B58, 1)), IF((object.Equals(AH20, 1)), Add(Subtract(Subtract(Plus(AB12), (Multiply(20, LOG10(BE20)))), 9), (Multiply(10, LOG10(Subtract(1, B58))))), Negate(999)), Negate(999));


	/// <summary>
	/// 10*LOG10((10^(AP20/10))+(10^(AW20/10))+(10^(BD20/10))+(10^(BF20/10)))
	/// </summary>
	public object BG20 => Multiply(10, LOG10(Add(Add(Add((Pow(10, (Divide(AP20, 10)))), (Pow(10, (Divide(AW20, 10))))), (Pow(10, (Divide(BD20, 10))))), (Pow(10, (Divide(BF20, 10)))))));


	/// <summary>
	/// IF((L20=1),IF((AI20=1),ROUND(10*LOG10((10^(AF20/10))+(10^(BG20/10))),0),""),"")
	/// </summary>
	public object BJ20 => IF((object.Equals(L20, 1)), IF((object.Equals(AI20, 1)), ROUND(Multiply(10, LOG10(Add((Pow(10, (Divide(AF20, 10)))), (Pow(10, (Divide(BG20, 10))))))), 0), ""), "");


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B18 {
		get => (double?)this[Addresses.B18];
		set => this[Addresses.B18] = value;
	}


	/// <summary>
	/// +MAX(B18,B19)
	/// </summary>
	public object Y17 => Plus(MAX(B18, B19));


	/// <summary>
	/// +Y17
	/// </summary>
	public object X112 => Plus(Y17);


	/// <summary>
	/// X7/(X112+X7)
	/// </summary>
	public object AL112 => Divide(X7, (Add(X112, X7)));


	/// <summary>
	/// +Z17
	/// </summary>
	public object Y51 => Plus(Z17);


	/// <summary>
	/// +Y51
	/// </summary>
	public object Y82 => Plus(Y51);


	/// <summary>
	/// +Y82+Y15
	/// </summary>
	public object Y83 => Add(Plus(Y82), Y15);


	/// <summary>
	/// +Y83+Y15
	/// </summary>
	public object Y84 => Add(Plus(Y83), Y15);


	/// <summary>
	/// +Y84+Y15
	/// </summary>
	public object Y85 => Add(Plus(Y84), Y15);


	/// <summary>
	/// +Y85+Y15
	/// </summary>
	public object Y86 => Add(Plus(Y85), Y15);


	/// <summary>
	/// +Y86+Y15
	/// </summary>
	public object Y87 => Add(Plus(Y86), Y15);


	/// <summary>
	/// +Y87+Y15
	/// </summary>
	public object Y88 => Add(Plus(Y87), Y15);


	/// <summary>
	/// +Y88+Y15
	/// </summary>
	public object Y89 => Add(Plus(Y88), Y15);


	/// <summary>
	/// +Y89+Y15
	/// </summary>
	public object Y90 => Add(Plus(Y89), Y15);


	/// <summary>
	/// +Y90+Y15
	/// </summary>
	public object Y91 => Add(Plus(Y90), Y15);


	/// <summary>
	/// +Y91+Y15
	/// </summary>
	public object Y92 => Add(Plus(Y91), Y15);


	/// <summary>
	/// +Y92+Y15
	/// </summary>
	public object Y93 => Add(Plus(Y92), Y15);


	/// <summary>
	/// +Y93+Y15
	/// </summary>
	public object Y94 => Add(Plus(Y93), Y15);


	/// <summary>
	/// +Y94+Y15
	/// </summary>
	public object Y95 => Add(Plus(Y94), Y15);


	/// <summary>
	/// +Y95+Y15
	/// </summary>
	public object Y96 => Add(Plus(Y95), Y15);


	/// <summary>
	/// +Y96+Y15
	/// </summary>
	public object Y97 => Add(Plus(Y96), Y15);


	/// <summary>
	/// +Y97+Y15
	/// </summary>
	public object Y98 => Add(Plus(Y97), Y15);


	/// <summary>
	/// +Y98+Y15
	/// </summary>
	public object Y99 => Add(Plus(Y98), Y15);


	/// <summary>
	/// +Y99+Y15
	/// </summary>
	public object Y100 => Add(Plus(Y99), Y15);


	/// <summary>
	/// +Y100+Y15
	/// </summary>
	public object Y101 => Add(Plus(Y100), Y15);


	/// <summary>
	/// +Y101+Y15
	/// </summary>
	public object Y102 => Add(Plus(Y101), Y15);


	/// <summary>
	/// +Y102+Y15
	/// </summary>
	public object Y103 => Add(Plus(Y102), Y15);


	/// <summary>
	/// +Y103+Y15
	/// </summary>
	public object Y104 => Add(Plus(Y103), Y15);


	/// <summary>
	/// +Y104+Y15
	/// </summary>
	public object Y105 => Add(Plus(Y104), Y15);


	/// <summary>
	/// +Y105+Y15
	/// </summary>
	public object Y106 => Add(Plus(Y105), Y15);


	/// <summary>
	/// +Y106+Y15
	/// </summary>
	public object Y107 => Add(Plus(Y106), Y15);


	/// <summary>
	/// +Y107+Y15
	/// </summary>
	public object Y108 => Add(Plus(Y107), Y15);


	/// <summary>
	/// +Y108+Y15
	/// </summary>
	public object Y109 => Add(Plus(Y108), Y15);


	/// <summary>
	/// +Y109+Y15
	/// </summary>
	public object Y110 => Add(Plus(Y109), Y15);


	/// <summary>
	/// +Y110+Y15
	/// </summary>
	public object Y111 => Add(Plus(Y110), Y15);


	/// <summary>
	/// +Y111+Y15
	/// </summary>
	public object Y112 => Add(Plus(Y111), Y15);


	/// <summary>
	/// IF(Y112<=B29,1,"")
	/// </summary>
	public object AI112 => IF(LessOrEqual(Y112, B29), 1, "");


	/// <summary>
	/// IF(SUM(AI20:AI112)=0,1,0)
	/// </summary>
	public object AK11 => IF(object.Equals(SUM((Addresses.AI20, Addresses.AI112)), 0), 1, 0);


	/// <summary>
	/// IF(AI112<>1,AB17,B30+0.5)
	/// </summary>
	public object Z112 => IF(!object.Equals(AI112, 1), AB17, Add(B30, 5));


	/// <summary>
	/// +SQRT(((X7-X112)^2)+((Y112-Y7)^2)+((Z112-Z7)^2))
	/// </summary>
	public object AE112 => Plus(SQRT(Add(Add((Pow((Subtract(X7, X112)), 2)), (Pow((Subtract(Y112, Y7)), 2))), (Pow((Subtract(Z112, Z7)), 2)))));


	/// <summary>
	/// +AB12-(20*LOG10(AE112))-9
	/// </summary>
	public object AF112 => Subtract(Subtract(Plus(AB12), (Multiply(20, LOG10(AE112)))), 9);


	/// <summary>
	/// (((X112-AJ112)^2)+((Y112-AK112)^2)+((Z112-Z7)^2))^0.5
	/// </summary>
	public object AN112 => Pow((Add(Add((Pow((Subtract(X112, AJ112)), 2)), (Pow((Subtract(Y112, AK112)), 2))), (Pow((Subtract(Z112, Z7)), 2)))), 5);


	/// <summary>
	/// (((X112-AX112)^2)+((Y112-AY112)^2)+((Z112-Z7)^2))^0.5
	/// </summary>
	public object BB112 => Pow((Add(Add((Pow((Subtract(X112, AX112)), 2)), (Pow((Subtract(Y112, AY112)), 2))), (Pow((Subtract(Z112, Z7)), 2)))), 5);


	/// <summary>
	/// +SQRT(((X7-X112)^2)+((Y112+Y7)^2)+((Z112-Z7)^2))
	/// </summary>
	public object BE112 => Plus(SQRT(Add(Add((Pow((Subtract(X7, X112)), 2)), (Pow((Add(Y112, Y7)), 2))), (Pow((Subtract(Z112, Z7)), 2)))));


	/// <summary>
	/// Y7+(AL112*(Y112-Y7))
	/// </summary>
	public object AM112 => Add(Y7, (Multiply(AL112, (Subtract(Y112, Y7)))));


	/// <summary>
	/// IF(AM112<=B27,1,0)
	/// </summary>
	public object AO112 => IF(LessOrEqual(AM112, B27), 1, 0);


	/// <summary>
	/// IF((AO112=1),(AB12-(20*LOG10(AN112))-9+(10*LOG10(1-B59))),-9999)
	/// </summary>
	public object AP112 => IF((object.Equals(AO112, 1)), (Add(Subtract(Subtract(AB12, (Multiply(20, LOG10(AN112)))), 9), (Multiply(10, LOG10(Subtract(1, B59)))))), Negate(9999));


	/// <summary>
	/// X7+(Y7*(X112-X7)/(Y112+Y7))
	/// </summary>
	public object AG112 => Add(X7, (Divide(Multiply(Y7, (Subtract(X112, X7))), (Add(Y112, Y7)))));


	/// <summary>
	/// IF(AG112>=X10,IF(AG112<=Y10,1,""),"")
	/// </summary>
	public object AH112 => IF(GreaterOrEqual(AG112, X10), IF(LessOrEqual(AG112, Y10), 1, ""), "");


	/// <summary>
	/// IF((B58<1),IF((AH112=1),+AB12-(20*LOG10(BE112))-9+(10*LOG10(1-B58)),-999),-999)
	/// </summary>
	public object BF112 => IF((Less(B58, 1)), IF((object.Equals(AH112, 1)), Add(Subtract(Subtract(Plus(AB12), (Multiply(20, LOG10(BE112)))), 9), (Multiply(10, LOG10(Subtract(1, B58))))), Negate(999)), Negate(999));


	/// <summary>
	/// (-B21+Y7)/(2*B21-Y7-Y112)
	/// </summary>
	public object AZ112 => Divide((Add(Negate(B21), Y7)), (Subtract(Subtract(Multiply(2, B21), Y7), Y112)));


	/// <summary>
	/// X7+(AZ112*(X7-X112))
	/// </summary>
	public object BA112 => Add(X7, (Multiply(AZ112, (Subtract(X7, X112)))));


	/// <summary>
	/// IF(AND(BA112>B31,BA112<B32),1,0)
	/// </summary>
	public object BC112 => IF(AND(Greater(BA112, B31), Less(BA112, B32)), 1, 0);


	/// <summary>
	/// IF(BC112=1,AB12-(20*LOG10(BB112))-9+(10*LOG10(1-B59)),-9999)
	/// </summary>
	public object BD112 => IF(object.Equals(BC112, 1), Add(Subtract(Subtract(AB12, (Multiply(20, LOG10(BB112)))), 9), (Multiply(10, LOG10(Subtract(1, B59))))), Negate(9999));


	/// <summary>
	/// 10*LOG10((10^(AP112/10))+(10^(AW112/10))+(10^(BD112/10))+(10^(BF112/10)))
	/// </summary>
	public object BG112 => Multiply(10, LOG10(Add(Add(Add((Pow(10, (Divide(AP112, 10)))), (Pow(10, (Divide(AW112, 10))))), (Pow(10, (Divide(BD112, 10))))), (Pow(10, (Divide(BF112, 10)))))));


	/// <summary>
	/// IF((L112=1),IF((AI112=1),ROUND(10*LOG10((10^(AF112/10))+(10^(BG112/10))),0),""),"")
	/// </summary>
	public object BJ112 => IF((object.Equals(L112, 1)), IF((object.Equals(AI112, 1)), ROUND(Multiply(10, LOG10(Add((Pow(10, (Divide(AF112, 10)))), (Pow(10, (Divide(BG112, 10))))))), 0), ""), "");


	/// <summary>
	/// MAX(BJ20:BJ112)
	/// </summary>
	public object BJ17 => MAX((Addresses.BJ20, Addresses.BJ112));


	/// <summary>
	/// IF(AK11=0,MAX(BJ20:BJ112),"")
	/// </summary>
	public object C66 => IF(object.Equals(AK11, 0), MAX((Addresses.BJ20, Addresses.BJ112)), "");


	/// <summary>
	/// IF(BJ17<>0,C66-C67,"")
	/// </summary>
	public object C68 => IF(!object.Equals(BJ17, 0), Subtract(C66, C67), "");


	/// <summary>
	/// IF(BJ17<>0,B15-C68,"")
	/// </summary>
	public object C69 => IF(!object.Equals(BJ17, 0), Subtract(B15, C68), "");


	/// <summary>
	/// IF(BJ17<>0,ROUND(45+C69,0),"")
	/// </summary>
	public object G50 => IF(!object.Equals(BJ17, 0), ROUND(Add(45, C69), 0), "");


	/// <summary>
	/// IF(G50<>"",-G50,-9999)
	/// </summary>
	public object G52 => IF(!object.Equals(G50, ""), Negate(G50), Negate(9999));


	/// <summary>
	/// (-MAX(C52:G52))-B16
	/// </summary>
	public object C54 => Subtract((Negate(MAX((Addresses.C52, Addresses.G52)))), B16);


	/// <summary>
	/// ROUND(C54,0)
	/// </summary>
	public object C74 => ROUND(C54, 0);


	/// <summary>
	/// IF((C88<=C74),"VOLDOET","VOLDOET NIET")
	/// </summary>
	public object B89 => IF((LessOrEqual(C88, C74)), "VOLDOET", "VOLDOET NIET");


	/// <summary>
	/// C54-5
	/// </summary>
	public object C55 => Subtract(C54, 5);


	/// <summary>
	/// ROUND(C55,0)
	/// </summary>
	public object F74 => ROUND(C55, 0);


	/// <summary>
	/// IF((F88<=F74),"VOLDOET","VOLDOET NIET")
	/// </summary>
	public object E89 => IF((LessOrEqual(F88, F74)), "VOLDOET", "VOLDOET NIET");

	public static class Addresses
	{
		public static readonly (int, int) AA17 = new(16, 26);
		public static readonly (int, int) AB12 = new(11, 27);
		public static readonly (int, int) AB17 = new(16, 27);
		public static readonly (int, int) AE112 = new(111, 30);
		public static readonly (int, int) AE20 = new(19, 30);
		public static readonly (int, int) AF112 = new(111, 31);
		public static readonly (int, int) AF20 = new(19, 31);
		public static readonly (int, int) AG112 = new(111, 32);
		public static readonly (int, int) AG20 = new(19, 32);
		public static readonly (int, int) AH112 = new(111, 33);
		public static readonly (int, int) AH20 = new(19, 33);
		public static readonly (int, int) AI112 = new(111, 34);
		public static readonly (int, int) AI20 = new(19, 34);
		public static readonly (int, int) AJ112 = new(111, 35);
		public static readonly (int, int) AJ20 = new(19, 35);
		public static readonly (int, int) AK11 = new(10, 36);
		public static readonly (int, int) AK112 = new(111, 36);
		public static readonly (int, int) AK20 = new(19, 36);
		public static readonly (int, int) AL112 = new(111, 37);
		public static readonly (int, int) AL20 = new(19, 37);
		public static readonly (int, int) AM112 = new(111, 38);
		public static readonly (int, int) AM20 = new(19, 38);
		public static readonly (int, int) AN112 = new(111, 39);
		public static readonly (int, int) AN20 = new(19, 39);
		public static readonly (int, int) AO112 = new(111, 40);
		public static readonly (int, int) AO20 = new(19, 40);
		public static readonly (int, int) AP112 = new(111, 41);
		public static readonly (int, int) AP20 = new(19, 41);
		public static readonly (int, int) AQ20 = new(19, 42);
		public static readonly (int, int) AR20 = new(19, 43);
		public static readonly (int, int) AS20 = new(19, 44);
		public static readonly (int, int) AT20 = new(19, 45);
		public static readonly (int, int) AU112 = new(111, 46);
		public static readonly (int, int) AU20 = new(19, 46);
		public static readonly (int, int) AV112 = new(111, 47);
		public static readonly (int, int) AV20 = new(19, 47);
		public static readonly (int, int) AW112 = new(111, 48);
		public static readonly (int, int) AW20 = new(19, 48);
		public static readonly (int, int) AX112 = new(111, 49);
		public static readonly (int, int) AY112 = new(111, 50);
		public static readonly (int, int) AZ112 = new(111, 51);
		public static readonly (int, int) B11 = new(10, 1);
		public static readonly (int, int) B12 = new(11, 1);
		public static readonly (int, int) B13 = new(12, 1);
		public static readonly (int, int) B15 = new(14, 1);
		public static readonly (int, int) B16 = new(15, 1);
		public static readonly (int, int) B18 = new(17, 1);
		public static readonly (int, int) B19 = new(18, 1);
		public static readonly (int, int) B20 = new(19, 1);
		public static readonly (int, int) B21 = new(20, 1);
		public static readonly (int, int) B22 = new(21, 1);
		public static readonly (int, int) B24 = new(23, 1);
		public static readonly (int, int) B25 = new(24, 1);
		public static readonly (int, int) B27 = new(26, 1);
		public static readonly (int, int) B29 = new(28, 1);
		public static readonly (int, int) B30 = new(29, 1);
		public static readonly (int, int) B31 = new(30, 1);
		public static readonly (int, int) B32 = new(31, 1);
		public static readonly (int, int) B33 = new(32, 1);
		public static readonly (int, int) B58 = new(57, 1);
		public static readonly (int, int) B59 = new(58, 1);
		public static readonly (int, int) BA112 = new(111, 52);
		public static readonly (int, int) BB112 = new(111, 53);
		public static readonly (int, int) BB20 = new(19, 53);
		public static readonly (int, int) BC112 = new(111, 54);
		public static readonly (int, int) BC20 = new(19, 54);
		public static readonly (int, int) BD112 = new(111, 55);
		public static readonly (int, int) BD20 = new(19, 55);
		public static readonly (int, int) BE112 = new(111, 56);
		public static readonly (int, int) BE20 = new(19, 56);
		public static readonly (int, int) BF112 = new(111, 57);
		public static readonly (int, int) BF20 = new(19, 57);
		public static readonly (int, int) BG112 = new(111, 58);
		public static readonly (int, int) BG20 = new(19, 58);
		public static readonly (int, int) BJ112 = new(111, 61);
		public static readonly (int, int) BJ17 = new(16, 61);
		public static readonly (int, int) BJ20 = new(19, 61);
		public static readonly (int, int) C35 = new(34, 2);
		public static readonly (int, int) C36 = new(35, 2);
		public static readonly (int, int) C37 = new(36, 2);
		public static readonly (int, int) C38 = new(37, 2);
		public static readonly (int, int) C39 = new(38, 2);
		public static readonly (int, int) C50 = new(49, 2);
		public static readonly (int, int) C52 = new(51, 2);
		public static readonly (int, int) C54 = new(53, 2);
		public static readonly (int, int) C55 = new(54, 2);
		public static readonly (int, int) C61 = new(60, 2);
		public static readonly (int, int) C62 = new(61, 2);
		public static readonly (int, int) C63 = new(62, 2);
		public static readonly (int, int) C64 = new(63, 2);
		public static readonly (int, int) C66 = new(65, 2);
		public static readonly (int, int) C67 = new(66, 2);
		public static readonly (int, int) C68 = new(67, 2);
		public static readonly (int, int) C69 = new(68, 2);
		public static readonly (int, int) C74 = new(73, 2);
		public static readonly (int, int) C85 = new(84, 2);
		public static readonly (int, int) C86 = new(85, 2);
		public static readonly (int, int) C87 = new(86, 2);
		public static readonly (int, int) C88 = new(87, 2);
		public static readonly (int, int) F74 = new(73, 5);
		public static readonly (int, int) F85 = new(84, 5);
		public static readonly (int, int) F86 = new(85, 5);
		public static readonly (int, int) F87 = new(86, 5);
		public static readonly (int, int) F88 = new(87, 5);
		public static readonly (int, int) G50 = new(49, 6);
		public static readonly (int, int) G52 = new(51, 6);
		public static readonly (int, int) I19 = new(18, 8);
		public static readonly (int, int) I21 = new(20, 8);
		public static readonly (int, int) L112 = new(111, 11);
		public static readonly (int, int) L20 = new(19, 11);
		public static readonly (int, int) X10 = new(9, 23);
		public static readonly (int, int) X112 = new(111, 23);
		public static readonly (int, int) X20 = new(19, 23);
		public static readonly (int, int) X7 = new(6, 23);
		public static readonly (int, int) Y10 = new(9, 24);
		public static readonly (int, int) Y100 = new(99, 24);
		public static readonly (int, int) Y101 = new(100, 24);
		public static readonly (int, int) Y102 = new(101, 24);
		public static readonly (int, int) Y103 = new(102, 24);
		public static readonly (int, int) Y104 = new(103, 24);
		public static readonly (int, int) Y105 = new(104, 24);
		public static readonly (int, int) Y106 = new(105, 24);
		public static readonly (int, int) Y107 = new(106, 24);
		public static readonly (int, int) Y108 = new(107, 24);
		public static readonly (int, int) Y109 = new(108, 24);
		public static readonly (int, int) Y110 = new(109, 24);
		public static readonly (int, int) Y111 = new(110, 24);
		public static readonly (int, int) Y112 = new(111, 24);
		public static readonly (int, int) Y15 = new(14, 24);
		public static readonly (int, int) Y17 = new(16, 24);
		public static readonly (int, int) Y20 = new(19, 24);
		public static readonly (int, int) Y51 = new(50, 24);
		public static readonly (int, int) Y7 = new(6, 24);
		public static readonly (int, int) Y82 = new(81, 24);
		public static readonly (int, int) Y83 = new(82, 24);
		public static readonly (int, int) Y84 = new(83, 24);
		public static readonly (int, int) Y85 = new(84, 24);
		public static readonly (int, int) Y86 = new(85, 24);
		public static readonly (int, int) Y87 = new(86, 24);
		public static readonly (int, int) Y88 = new(87, 24);
		public static readonly (int, int) Y89 = new(88, 24);
		public static readonly (int, int) Y90 = new(89, 24);
		public static readonly (int, int) Y91 = new(90, 24);
		public static readonly (int, int) Y92 = new(91, 24);
		public static readonly (int, int) Y93 = new(92, 24);
		public static readonly (int, int) Y94 = new(93, 24);
		public static readonly (int, int) Y95 = new(94, 24);
		public static readonly (int, int) Y96 = new(95, 24);
		public static readonly (int, int) Y97 = new(96, 24);
		public static readonly (int, int) Y98 = new(97, 24);
		public static readonly (int, int) Y99 = new(98, 24);
		public static readonly (int, int) Z112 = new(111, 25);
		public static readonly (int, int) Z17 = new(16, 25);
		public static readonly (int, int) Z20 = new(19, 25);
		public static readonly (int, int) Z7 = new(6, 25);
	}
}
