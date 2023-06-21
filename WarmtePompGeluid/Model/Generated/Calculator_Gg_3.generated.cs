using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Ambacht.Common.Excel;

namespace WarmtePompGeluid.Model.Generated;

public class Calculator_Gg_3 : ExcelCalculatorBase {

	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? C82 {
		get => (double?)this[Addresses.C82];
		set => this[Addresses.C82] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? C83 {
		get => (double?)this[Addresses.C83];
		set => this[Addresses.C83] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? C84 {
		get => (double?)this[Addresses.C84];
		set => this[Addresses.C84] = value;
	}


	/// <summary>
	/// C82+C83-C84
	/// </summary>
	public object C85 => Subtract(Add(C82, C83), C84);


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? F82 {
		get => (double?)this[Addresses.F82];
		set => this[Addresses.F82] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? F83 {
		get => (double?)this[Addresses.F83];
		set => this[Addresses.F83] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? F84 {
		get => (double?)this[Addresses.F84];
		set => this[Addresses.F84] = value;
	}


	/// <summary>
	/// F82+F83-F84
	/// </summary>
	public object F85 => Subtract(Add(F82, F83), F84);


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
	public double? C30 {
		get => (double?)this[Addresses.C30];
		set => this[Addresses.C30] = value;
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
	public double? C31 {
		get => (double?)this[Addresses.C31];
		set => this[Addresses.C31] = value;
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
	public double? C32 {
		get => (double?)this[Addresses.C32];
		set => this[Addresses.C32] = value;
	}


	/// <summary>
	/// SQRT(((B11-C30)^2)+((B12-C31)^2)+((B13-C32)^2))
	/// </summary>
	public object C56 => SQRT(Add(Add((Pow((Subtract(B11, C30)), 2)), (Pow((Subtract(B12, C31)), 2))), (Pow((Subtract(B13, C32)), 2))));


	/// <summary>
	/// variable (String)
	/// </summary>
	public string C33 {
		get => (string)this[Addresses.C33];
		set => this[Addresses.C33] = value;
	}


	/// <summary>
	/// IF(C33="J",5,0)
	/// </summary>
	public object C57 => IF(object.Equals(C33, "J"), 5, 0);


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? C34 {
		get => (double?)this[Addresses.C34];
		set => this[Addresses.C34] = value;
	}


	/// <summary>
	/// 10*LOG10(2/C34)
	/// </summary>
	public object C58 => Multiply(10, LOG10(Divide(2, C34)));


	/// <summary>
	/// 20*LOG10(C56)+9+C57-C58
	/// </summary>
	public object C59 => Subtract(Add(Add(Multiply(20, LOG10(C56)), 9), C57), C58);


	/// <summary>
	/// IF(C30="nvt","",ROUND(45+C59,0))
	/// </summary>
	public object C49 => IF(object.Equals(C30, "nvt"), "", ROUND(Add(45, C59), 0));


	/// <summary>
	/// IF(C49<>"",-C49,-9999)
	/// </summary>
	public object C51 => IF(!object.Equals(C49, ""), Negate(C49), Negate(9999));


	/// <summary>
	/// B15
	/// </summary>
	public object AB10 => B15;


	/// <summary>
	/// variable (String)
	/// </summary>
	public string I20 {
		get => (string)this[Addresses.I20];
		set => this[Addresses.I20] = value;
	}


	/// <summary>
	/// IF(I20="j",1,0)
	/// </summary>
	public object L18 => IF(object.Equals(I20, "j"), 1, 0);


	/// <summary>
	/// B11
	/// </summary>
	public object X6 => B11;


	/// <summary>
	/// B12
	/// </summary>
	public object Y6 => B12;


	/// <summary>
	/// B13
	/// </summary>
	public object Z6 => B13;


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
	public object L144 => IF(object.Equals(I19, "j"), 1, 0);


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B26 {
		get => (double?)this[Addresses.B26];
		set => this[Addresses.B26] = value;
	}


	/// <summary>
	/// B26
	/// </summary>
	public object Z8 => B26;


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
	public object Z15 => Plus(MIN(B20, B21));


	/// <summary>
	/// +Z15
	/// </summary>
	public object Y18 => Plus(Z15);


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
	public object X8 => B24;


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
	public object Y8 => B25;


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? AB11 {
		get => (double?)this[Addresses.AB11];
		set => this[Addresses.AB11] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? BQ18 {
		get => (double?)this[Addresses.BQ18];
		set => this[Addresses.BQ18] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B18 {
		get => (double?)this[Addresses.B18];
		set => this[Addresses.B18] = value;
	}


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B19 {
		get => (double?)this[Addresses.B19];
		set => this[Addresses.B19] = value;
	}


	/// <summary>
	/// +MAX(B18,B19)
	/// </summary>
	public object Y15 => Plus(MAX(B18, B19));


	/// <summary>
	/// +Y15
	/// </summary>
	public object X144 => Plus(Y15);


	/// <summary>
	/// +MIN(B18,B19)
	/// </summary>
	public object X15 => Plus(MIN(B18, B19));


	/// <summary>
	/// +X15
	/// </summary>
	public object X18 => Plus(X15);


	/// <summary>
	/// IF(Z8<=Z15,IF(X18>=X8,IF(X18<=Y8,1,0),0),0)
	/// </summary>
	public object AO18 => IF(LessOrEqual(Z8, Z15), IF(GreaterOrEqual(X18, X8), IF(LessOrEqual(X18, Y8), 1, 0), 0), 0);


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B27 {
		get => (double?)this[Addresses.B27];
		set => this[Addresses.B27] = value;
	}


	/// <summary>
	/// +B27
	/// </summary>
	public object AA8 => Plus(B27);


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? BQ144 {
		get => (double?)this[Addresses.BQ144];
		set => this[Addresses.BQ144] = value;
	}


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
	public object AB15 => Plus(B22);


	/// <summary>
	/// +AB15
	/// </summary>
	public object Z18 => Plus(AB15);


	/// <summary>
	/// +SQRT(((X6-X18)^2)+((Y18-Y6)^2)+((Z18-Z6)^2))
	/// </summary>
	public object BV18 => Plus(SQRT(Add(Add((Pow((Subtract(X6, X18)), 2)), (Pow((Subtract(Y18, Y6)), 2))), (Pow((Subtract(Z18, Z6)), 2)))));


	/// <summary>
	/// +AB15
	/// </summary>
	public object Z144 => Plus(AB15);


	/// <summary>
	/// +MAX(B20,B21)
	/// </summary>
	public object AA15 => Plus(MAX(B20, B21));


	/// <summary>
	/// +(AA15-Z15)/30
	/// </summary>
	public object Y13 => Divide(Plus((Subtract(AA15, Z15))), 30);


	/// <summary>
	/// variable (Numeric)
	/// </summary>
	public double? B28 {
		get => (double?)this[Addresses.B28];
		set => this[Addresses.B28] = value;
	}


	/// <summary>
	/// +B28
	/// </summary>
	public object AB8 => Plus(B28);


	/// <summary>
	/// +AB8
	/// </summary>
	public object AJ18 => Plus(AB8);


	/// <summary>
	/// +AJ18
	/// </summary>
	public object BP18 => Plus(AJ18);


	/// <summary>
	/// IF(((BP18-BQ18)*(AB11/(2^(1/3)))/250)<1,(BP18-BQ18)*(AB11/(2^(1/3)))/250,1)
	/// </summary>
	public object BR18 => IF(Less((Divide(Multiply((Subtract(BP18, BQ18)), (Divide(AB11, (Pow(2, (Divide(1, 3))))))), 250)), 1), Divide(Multiply((Subtract(BP18, BQ18)), (Divide(AB11, (Pow(2, (Divide(1, 3))))))), 250), 1);


	/// <summary>
	/// +AB8
	/// </summary>
	public object AJ144 => Plus(AB8);


	/// <summary>
	/// +AJ144
	/// </summary>
	public object BP144 => Plus(AJ144);


	/// <summary>
	/// IF(((BP144-BQ144)*(AB11/(2^(1/3)))/250)<1,(BP144-BQ144)*(AB11/(2^(1/3)))/250,1)
	/// </summary>
	public object BR144 => IF(Less((Divide(Multiply((Subtract(BP144, BQ144)), (Divide(AB11, (Pow(2, (Divide(1, 3))))))), 250)), 1), Divide(Multiply((Subtract(BP144, BQ144)), (Divide(AB11, (Pow(2, (Divide(1, 3))))))), 250), 1);


	/// <summary>
	/// +X6+((X18-X6)*(Z8-Y6)/(Y18-Y6))
	/// </summary>
	public object AC18 => Add(Plus(X6), (Divide(Multiply((Subtract(X18, X6)), (Subtract(Z8, Y6))), (Subtract(Y18, Y6)))));


	/// <summary>
	/// IF(AC18<X8,X8,IF(AC18>Y8,Y8,AC18))
	/// </summary>
	public object AE18 => IF(Less(AC18, X8), X8, IF(Greater(AC18, Y8), Y8, AC18));


	/// <summary>
	/// IF((X18-X6)<>0,+Y6+((Y18-Y6)*(X8-X6)/(X18-X6)),-100000)
	/// </summary>
	public object AA18 => IF(!object.Equals((Subtract(X18, X6)), 0), Add(Plus(Y6), (Divide(Multiply((Subtract(Y18, Y6)), (Subtract(X8, X6))), (Subtract(X18, X6))))), Negate(100000));


	/// <summary>
	/// IF((X18-X6)<>0,+Y6+((Y18-Y6)*(Y8-X6)/(X18-X6)),100000)
	/// </summary>
	public object AB18 => IF(!object.Equals((Subtract(X18, X6)), 0), Add(Plus(Y6), (Divide(Multiply((Subtract(Y18, Y6)), (Subtract(Y8, X6))), (Subtract(X18, X6))))), 100000);


	/// <summary>
	/// IF(AC18<X8,AA18,IF(AC18>Y8,AB18,Z8))
	/// </summary>
	public object AF18 => IF(Less(AC18, X8), AA18, IF(Greater(AC18, Y8), AB18, Z8));


	/// <summary>
	/// +SQRT(((AE18-X6)^2)+((Y6-AF18)^2))
	/// </summary>
	public object AG18 => Plus(SQRT(Add((Pow((Subtract(AE18, X6)), 2)), (Pow((Subtract(Y6, AF18)), 2)))));


	/// <summary>
	/// +SQRT(AG18^2+((AJ18-Z6)^2))
	/// </summary>
	public object AK18 => Plus(SQRT(Pow(AG18, Add(2, (Pow((Subtract(AJ18, Z6)), 2))))));


	/// <summary>
	/// +SQRT(((X18-AE18)^2)+((Y18-AF18)^2))
	/// </summary>
	public object AH18 => Plus(SQRT(Add((Pow((Subtract(X18, AE18)), 2)), (Pow((Subtract(Y18, AF18)), 2)))));


	/// <summary>
	/// +Z6+((Z18-Z6)*AG18/(AG18+AH18))
	/// </summary>
	public object AI18 => Add(Plus(Z6), (Divide(Multiply((Subtract(Z18, Z6)), AG18), (Add(AG18, AH18)))));


	/// <summary>
	/// +SQRT(AH18^2+((AJ18-Z18)^2))
	/// </summary>
	public object AL18 => Plus(SQRT(Pow(AH18, Add(2, (Pow((Subtract(AJ18, Z18)), 2))))));


	/// <summary>
	/// +SQRT(AG18^2+((AI18-Z6)^2))
	/// </summary>
	public object AM18 => Plus(SQRT(Pow(AG18, Add(2, (Pow((Subtract(AI18, Z6)), 2))))));


	/// <summary>
	/// +SQRT(AH18^2+((AI18-Z18)^2))
	/// </summary>
	public object AN18 => Plus(SQRT(Pow(AH18, Add(2, (Pow((Subtract(AI18, Z18)), 2))))));


	/// <summary>
	/// +IF(AJ18>AI18,AK18+AL18-AM18-AN18,AM18+AN18-AK18-AL18)
	/// </summary>
	public object AR18 => Plus(IF(Greater(AJ18, AI18), Subtract(Subtract(Add(AK18, AL18), AM18), AN18), Subtract(Subtract(Add(AM18, AN18), AK18), AL18)));


	/// <summary>
	/// 0.0059*AR18*(AB11/(2^(1/3)))
	/// </summary>
	public object AS18 => Multiply(Multiply(59, AR18), (Divide(AB11, (Pow(2, (Divide(1, 3)))))));


	/// <summary>
	/// Y6-Y18
	/// </summary>
	public object AU18 => Subtract(Y6, Y18);


	/// <summary>
	/// X6-X18
	/// </summary>
	public object AT18 => Subtract(X6, X18);


	/// <summary>
	/// -((AT18^2)+(AU18^2))/(Z6-Z18)
	/// </summary>
	public object AV18 => Divide(Negate((Add((Pow(AT18, 2)), (Pow(AU18, 2))))), (Subtract(Z6, Z18)));


	/// <summary>
	/// SQRT((AT18^2)+(AU18^2)+(AV18^2))
	/// </summary>
	public object AW18 => SQRT(Add(Add((Pow(AT18, 2)), (Pow(AU18, 2))), (Pow(AV18, 2))));


	/// <summary>
	/// AU18/AW18
	/// </summary>
	public object AY18 => Divide(AU18, AW18);


	/// <summary>
	/// AT18/AW18
	/// </summary>
	public object AX18 => Divide(AT18, AW18);


	/// <summary>
	/// AV18/AW18
	/// </summary>
	public object AZ18 => Divide(AV18, AW18);


	/// <summary>
	/// (-((AX18*X6)+(AY18*Y6)+(AZ18*Z6)))
	/// </summary>
	public object BA18 => (Negate((Add(Add((Multiply(AX18, X6)), (Multiply(AY18, Y6))), (Multiply(AZ18, Z6))))));


	/// <summary>
	/// IF(AY18<>0,(-(BA18+(AX18*X8)+(AZ18*AB8))/AY18),1000)
	/// </summary>
	public object BB18 => IF(!object.Equals(AY18, 0), (Divide(Negate((Add(Add(BA18, (Multiply(AX18, X8))), (Multiply(AZ18, AB8))))), AY18)), 1000);


	/// <summary>
	/// ((((X6-X8)^2)+((Y6-BB18)^2)+((Z6-AB8)^2))^0.5)+((((X8-X18)^2)+((BB18-Y18)^2)+((AB8-Z18)^2))^0.5)-BV18
	/// </summary>
	public object BJ18 => Subtract(Add((Pow((Add(Add((Pow((Subtract(X6, X8)), 2)), (Pow((Subtract(Y6, BB18)), 2))), (Pow((Subtract(Z6, AB8)), 2)))), 5)), (Pow((Add(Add((Pow((Subtract(X8, X18)), 2)), (Pow((Subtract(BB18, Y18)), 2))), (Pow((Subtract(AB8, Z18)), 2)))), 5))), BV18);


	/// <summary>
	/// IF(AY18<>0,(-(BA18+(AX18*Y8)+(AZ18*AB8))/AY18),1000)
	/// </summary>
	public object BC18 => IF(!object.Equals(AY18, 0), (Divide(Negate((Add(Add(BA18, (Multiply(AX18, Y8))), (Multiply(AZ18, AB8))))), AY18)), 1000);


	/// <summary>
	/// ((((X6-Y8)^2)+((Y6-BC18)^2)+((Z6-AB8)^2))^0.5)+((((Y8-X18)^2)+((BC18-Y18)^2)+((AB8-Z18)^2))^0.5)-BV18
	/// </summary>
	public object BM18 => Subtract(Add((Pow((Add(Add((Pow((Subtract(X6, Y8)), 2)), (Pow((Subtract(Y6, BC18)), 2))), (Pow((Subtract(Z6, AB8)), 2)))), 5)), (Pow((Add(Add((Pow((Subtract(Y8, X18)), 2)), (Pow((Subtract(BC18, Y18)), 2))), (Pow((Subtract(AB8, Z18)), 2)))), 5))), BV18);


	/// <summary>
	/// MIN(BJ18:BM18)
	/// </summary>
	public object BN18 => MIN((Addresses.BJ18, Addresses.BM18));


	/// <summary>
	/// 0.0059*BN18*(AB11/(2^(1/3)))
	/// </summary>
	public object BO18 => Multiply(Multiply(59, BN18), (Divide(AB11, (Pow(2, (Divide(1, 3)))))));


	/// <summary>
	/// +IF((AS18>(-0.1)),(10*BR18*LOG10(1/((1/(20*AS18+3))+(1/(20*BO18+3))))),0)
	/// </summary>
	public object BT18 => Plus(IF((Greater(AS18, (Negate(1)))), (Multiply(Multiply(10, BR18), LOG10(Divide(1, (Add((Divide(1, (Add(Multiply(20, AS18), 3)))), (Divide(1, (Add(Multiply(20, BO18), 3)))))))))), 0));


	/// <summary>
	/// IF((L18=1),IF((AO18=0),ROUND((+AB10-(20*LOG10(BV18))-9-BT18),0),""),"")
	/// </summary>
	public object BW18 => IF((object.Equals(L18, 1)), IF((object.Equals(AO18, 0)), ROUND((Subtract(Subtract(Subtract(Plus(AB10), (Multiply(20, LOG10(BV18)))), 9), BT18)), 0), ""), "");


	/// <summary>
	/// X6-X144
	/// </summary>
	public object AT144 => Subtract(X6, X144);


	/// <summary>
	/// +Z15
	/// </summary>
	public object Y83 => Plus(Z15);


	/// <summary>
	/// +Y83
	/// </summary>
	public object Y114 => Plus(Y83);


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
	/// +Y141+Y13
	/// </summary>
	public object Y142 => Add(Plus(Y141), Y13);


	/// <summary>
	/// +Y142+Y13
	/// </summary>
	public object Y143 => Add(Plus(Y142), Y13);


	/// <summary>
	/// +Y143+Y13
	/// </summary>
	public object Y144 => Add(Plus(Y143), Y13);


	/// <summary>
	/// IF(Y8>Y15,IF(Y144>=Z8,IF(Y144<AA8,1,0),0),0)
	/// </summary>
	public object AO144 => IF(Greater(Y8, Y15), IF(GreaterOrEqual(Y144, Z8), IF(Less(Y144, AA8), 1, 0), 0), 0);


	/// <summary>
	/// +SQRT(((X6-X144)^2)+((Y144-Y6)^2)+((Z144-Z6)^2))
	/// </summary>
	public object BV144 => Plus(SQRT(Add(Add((Pow((Subtract(X6, X144)), 2)), (Pow((Subtract(Y144, Y6)), 2))), (Pow((Subtract(Z144, Z6)), 2)))));


	/// <summary>
	/// +Y6+((Y144-Y6)*(Y8-X6)/(X144-X6))
	/// </summary>
	public object AB144 => Add(Plus(Y6), (Divide(Multiply((Subtract(Y144, Y6)), (Subtract(Y8, X6))), (Subtract(X144, X6)))));


	/// <summary>
	/// IF(AB144<Z8,Z8,IF(AB144>AA8,AA8,AB144))
	/// </summary>
	public object AF144 => IF(Less(AB144, Z8), Z8, IF(Greater(AB144, AA8), AA8, AB144));


	/// <summary>
	/// IF((Y144-Y6)<>0,+X6+((X144-X6)*(Z8-Y6)/(Y144-Y6)),-100000)
	/// </summary>
	public object AC144 => IF(!object.Equals((Subtract(Y144, Y6)), 0), Add(Plus(X6), (Divide(Multiply((Subtract(X144, X6)), (Subtract(Z8, Y6))), (Subtract(Y144, Y6))))), Negate(100000));


	/// <summary>
	/// IF((Y144-Y6)<>0,+X6+((X144-X6)*(AA8-Y6)/(Y144-Y6)),100000)
	/// </summary>
	public object AD144 => IF(!object.Equals((Subtract(Y144, Y6)), 0), Add(Plus(X6), (Divide(Multiply((Subtract(X144, X6)), (Subtract(AA8, Y6))), (Subtract(Y144, Y6))))), 100000);


	/// <summary>
	/// IF(AB144<Z8,AC144,IF(AB144>AA8,AD144,Y8))
	/// </summary>
	public object AE144 => IF(Less(AB144, Z8), AC144, IF(Greater(AB144, AA8), AD144, Y8));


	/// <summary>
	/// +SQRT(((AE144-X6)^2)+((Y6-AF144)^2))
	/// </summary>
	public object AG144 => Plus(SQRT(Add((Pow((Subtract(AE144, X6)), 2)), (Pow((Subtract(Y6, AF144)), 2)))));


	/// <summary>
	/// +SQRT(AG144^2+((AJ144-Z6)^2))
	/// </summary>
	public object AK144 => Plus(SQRT(Pow(AG144, Add(2, (Pow((Subtract(AJ144, Z6)), 2))))));


	/// <summary>
	/// +SQRT(((X144-AE144)^2)+((Y144-AF144)^2))
	/// </summary>
	public object AH144 => Plus(SQRT(Add((Pow((Subtract(X144, AE144)), 2)), (Pow((Subtract(Y144, AF144)), 2)))));


	/// <summary>
	/// +Z6+((Z144-Z6)*AG144/(AG144+AH144))
	/// </summary>
	public object AI144 => Add(Plus(Z6), (Divide(Multiply((Subtract(Z144, Z6)), AG144), (Add(AG144, AH144)))));


	/// <summary>
	/// +SQRT(AH144^2+((AJ144-Z144)^2))
	/// </summary>
	public object AL144 => Plus(SQRT(Pow(AH144, Add(2, (Pow((Subtract(AJ144, Z144)), 2))))));


	/// <summary>
	/// +SQRT(AG144^2+((AI144-Z6)^2))
	/// </summary>
	public object AM144 => Plus(SQRT(Pow(AG144, Add(2, (Pow((Subtract(AI144, Z6)), 2))))));


	/// <summary>
	/// +SQRT(AH144^2+((AI144-Z144)^2))
	/// </summary>
	public object AN144 => Plus(SQRT(Pow(AH144, Add(2, (Pow((Subtract(AI144, Z144)), 2))))));


	/// <summary>
	/// +IF(AJ144>AI144,AK144+AL144-AM144-AN144,AM144+AN144-AK144-AL144)
	/// </summary>
	public object AR144 => Plus(IF(Greater(AJ144, AI144), Subtract(Subtract(Add(AK144, AL144), AM144), AN144), Subtract(Subtract(Add(AM144, AN144), AK144), AL144)));


	/// <summary>
	/// 0.0059*AR144*(AB11/(2^(1/3)))
	/// </summary>
	public object AS144 => Multiply(Multiply(59, AR144), (Divide(AB11, (Pow(2, (Divide(1, 3)))))));


	/// <summary>
	/// Y6-Y144
	/// </summary>
	public object AU144 => Subtract(Y6, Y144);


	/// <summary>
	/// -((AT144^2)+(AU144^2))/(Z6-Z144)
	/// </summary>
	public object AV144 => Divide(Negate((Add((Pow(AT144, 2)), (Pow(AU144, 2))))), (Subtract(Z6, Z144)));


	/// <summary>
	/// SQRT((AT144^2)+(AU144^2)+(AV144^2))
	/// </summary>
	public object AW144 => SQRT(Add(Add((Pow(AT144, 2)), (Pow(AU144, 2))), (Pow(AV144, 2))));


	/// <summary>
	/// AT144/AW144
	/// </summary>
	public object AX144 => Divide(AT144, AW144);


	/// <summary>
	/// AU144/AW144
	/// </summary>
	public object AY144 => Divide(AU144, AW144);


	/// <summary>
	/// AV144/AW144
	/// </summary>
	public object AZ144 => Divide(AV144, AW144);


	/// <summary>
	/// (-((AX144*X6)+(AY144*Y6)+(AZ144*Z6)))
	/// </summary>
	public object BA144 => (Negate((Add(Add((Multiply(AX144, X6)), (Multiply(AY144, Y6))), (Multiply(AZ144, Z6))))));


	/// <summary>
	/// IF(AX144<>0,(-(BA144+(AY144*Z8)+(AZ144*AB8))/AX144),1000)
	/// </summary>
	public object BD144 => IF(!object.Equals(AX144, 0), (Divide(Negate((Add(Add(BA144, (Multiply(AY144, Z8))), (Multiply(AZ144, AB8))))), AX144)), 1000);


	/// <summary>
	/// ((X6-BD144)^2+(Y6-Z8)^2+(Z6-AB8)^2)^0.5+((BD144-X144)^2+(Z8-Y144)^2+(AB8-Z144)^2)^0.5-BV144
	/// </summary>
	public object BJ144 => Pow(Pow((Pow(Pow(Pow((Subtract(X6, BD144)), Add(2, (Subtract(Y6, Z8)))), Add(2, (Subtract(Z6, AB8)))), 2)), Add(5, (Pow(Pow(Pow((Subtract(BD144, X144)), Add(2, (Subtract(Z8, Y144)))), Add(2, (Subtract(AB8, Z144)))), 2)))), Subtract(5, BV144));


	/// <summary>
	/// IF(AX144<>0,(-(BA144+(AY144*AA8)+(AZ144*AB8))/AX144),1000)
	/// </summary>
	public object BE144 => IF(!object.Equals(AX144, 0), (Divide(Negate((Add(Add(BA144, (Multiply(AY144, AA8))), (Multiply(AZ144, AB8))))), AX144)), 1000);


	/// <summary>
	/// ((X6-BE144)^2+(Y6-AA8)^2+(Z6-AB8)^2)^0.5+((BE144-X144)^2+(AA8-Y144)^2+(AB8-Z144)^2)^0.5-BV144
	/// </summary>
	public object BM144 => Pow(Pow((Pow(Pow(Pow((Subtract(X6, BE144)), Add(2, (Subtract(Y6, AA8)))), Add(2, (Subtract(Z6, AB8)))), 2)), Add(5, (Pow(Pow(Pow((Subtract(BE144, X144)), Add(2, (Subtract(AA8, Y144)))), Add(2, (Subtract(AB8, Z144)))), 2)))), Subtract(5, BV144));


	/// <summary>
	/// MIN(BJ144:BM144)
	/// </summary>
	public object BN144 => MIN((Addresses.BJ144, Addresses.BM144));


	/// <summary>
	/// 0.0059*BN144*(AB11/(2^(1/3)))
	/// </summary>
	public object BO144 => Multiply(Multiply(59, BN144), (Divide(AB11, (Pow(2, (Divide(1, 3)))))));


	/// <summary>
	/// +IF((AS144>(-0.1)),(10*BR144*LOG10(1/((1/(20*AS144+3))+(1/(20*BO144+3))))),0)
	/// </summary>
	public object BT144 => Plus(IF((Greater(AS144, (Negate(1)))), (Multiply(Multiply(10, BR144), LOG10(Divide(1, (Add((Divide(1, (Add(Multiply(20, AS144), 3)))), (Divide(1, (Add(Multiply(20, BO144), 3)))))))))), 0));


	/// <summary>
	/// IF((L144=1),IF((AO144=0),ROUND((+AB10-(20*LOG10(BV144))-9-BT144),0),""),"")
	/// </summary>
	public object BW144 => IF((object.Equals(L144, 1)), IF((object.Equals(AO144, 0)), ROUND((Subtract(Subtract(Subtract(Plus(AB10), (Multiply(20, LOG10(BV144)))), 9), BT144)), 0), ""), "");


	/// <summary>
	/// MAX(BW18:BW144)
	/// </summary>
	public object F38 => MAX((Addresses.BW18, Addresses.BW144));


	/// <summary>
	/// B15-F38
	/// </summary>
	public object F59 => Subtract(B15, F38);


	/// <summary>
	/// ROUND(45+F59,0)
	/// </summary>
	public object F49 => ROUND(Add(45, F59), 0);


	/// <summary>
	/// IF(F49<>"",-F49,-9999)
	/// </summary>
	public object F51 => IF(!object.Equals(F49, ""), Negate(F49), Negate(9999));


	/// <summary>
	/// (-MAX(C51:F51))-B16
	/// </summary>
	public object C45 => Subtract((Negate(MAX((Addresses.C51, Addresses.F51)))), B16);


	/// <summary>
	/// ROUND(C45,0)
	/// </summary>
	public object C71 => ROUND(C45, 0);


	/// <summary>
	/// IF(C85<=C71,"VOLDOET","VOLDOET NIET")
	/// </summary>
	public object B86 => IF(LessOrEqual(C85, C71), "VOLDOET", "VOLDOET NIET");


	/// <summary>
	/// C45-5
	/// </summary>
	public object C46 => Subtract(C45, 5);


	/// <summary>
	/// ROUND(C46,0)
	/// </summary>
	public object F71 => ROUND(C46, 0);


	/// <summary>
	/// IF(F85<=F71,"VOLDOET","VOLDOET NIET")
	/// </summary>
	public object E86 => IF(LessOrEqual(F85, F71), "VOLDOET", "VOLDOET NIET");

	public static class Addresses
	{
		public static readonly (int, int) AA15 = new(14, 26);
		public static readonly (int, int) AA18 = new(17, 26);
		public static readonly (int, int) AA8 = new(7, 26);
		public static readonly (int, int) AB10 = new(9, 27);
		public static readonly (int, int) AB11 = new(10, 27);
		public static readonly (int, int) AB144 = new(143, 27);
		public static readonly (int, int) AB15 = new(14, 27);
		public static readonly (int, int) AB18 = new(17, 27);
		public static readonly (int, int) AB8 = new(7, 27);
		public static readonly (int, int) AC144 = new(143, 28);
		public static readonly (int, int) AC18 = new(17, 28);
		public static readonly (int, int) AD144 = new(143, 29);
		public static readonly (int, int) AE144 = new(143, 30);
		public static readonly (int, int) AE18 = new(17, 30);
		public static readonly (int, int) AF144 = new(143, 31);
		public static readonly (int, int) AF18 = new(17, 31);
		public static readonly (int, int) AG144 = new(143, 32);
		public static readonly (int, int) AG18 = new(17, 32);
		public static readonly (int, int) AH144 = new(143, 33);
		public static readonly (int, int) AH18 = new(17, 33);
		public static readonly (int, int) AI144 = new(143, 34);
		public static readonly (int, int) AI18 = new(17, 34);
		public static readonly (int, int) AJ144 = new(143, 35);
		public static readonly (int, int) AJ18 = new(17, 35);
		public static readonly (int, int) AK144 = new(143, 36);
		public static readonly (int, int) AK18 = new(17, 36);
		public static readonly (int, int) AL144 = new(143, 37);
		public static readonly (int, int) AL18 = new(17, 37);
		public static readonly (int, int) AM144 = new(143, 38);
		public static readonly (int, int) AM18 = new(17, 38);
		public static readonly (int, int) AN144 = new(143, 39);
		public static readonly (int, int) AN18 = new(17, 39);
		public static readonly (int, int) AO144 = new(143, 40);
		public static readonly (int, int) AO18 = new(17, 40);
		public static readonly (int, int) AR144 = new(143, 43);
		public static readonly (int, int) AR18 = new(17, 43);
		public static readonly (int, int) AS144 = new(143, 44);
		public static readonly (int, int) AS18 = new(17, 44);
		public static readonly (int, int) AT144 = new(143, 45);
		public static readonly (int, int) AT18 = new(17, 45);
		public static readonly (int, int) AU144 = new(143, 46);
		public static readonly (int, int) AU18 = new(17, 46);
		public static readonly (int, int) AV144 = new(143, 47);
		public static readonly (int, int) AV18 = new(17, 47);
		public static readonly (int, int) AW144 = new(143, 48);
		public static readonly (int, int) AW18 = new(17, 48);
		public static readonly (int, int) AX144 = new(143, 49);
		public static readonly (int, int) AX18 = new(17, 49);
		public static readonly (int, int) AY144 = new(143, 50);
		public static readonly (int, int) AY18 = new(17, 50);
		public static readonly (int, int) AZ144 = new(143, 51);
		public static readonly (int, int) AZ18 = new(17, 51);
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
		public static readonly (int, int) B26 = new(25, 1);
		public static readonly (int, int) B27 = new(26, 1);
		public static readonly (int, int) B28 = new(27, 1);
		public static readonly (int, int) BA144 = new(143, 52);
		public static readonly (int, int) BA18 = new(17, 52);
		public static readonly (int, int) BB18 = new(17, 53);
		public static readonly (int, int) BC18 = new(17, 54);
		public static readonly (int, int) BD144 = new(143, 55);
		public static readonly (int, int) BE144 = new(143, 56);
		public static readonly (int, int) BJ144 = new(143, 61);
		public static readonly (int, int) BJ18 = new(17, 61);
		public static readonly (int, int) BM144 = new(143, 64);
		public static readonly (int, int) BM18 = new(17, 64);
		public static readonly (int, int) BN144 = new(143, 65);
		public static readonly (int, int) BN18 = new(17, 65);
		public static readonly (int, int) BO144 = new(143, 66);
		public static readonly (int, int) BO18 = new(17, 66);
		public static readonly (int, int) BP144 = new(143, 67);
		public static readonly (int, int) BP18 = new(17, 67);
		public static readonly (int, int) BQ144 = new(143, 68);
		public static readonly (int, int) BQ18 = new(17, 68);
		public static readonly (int, int) BR144 = new(143, 69);
		public static readonly (int, int) BR18 = new(17, 69);
		public static readonly (int, int) BT144 = new(143, 71);
		public static readonly (int, int) BT18 = new(17, 71);
		public static readonly (int, int) BV144 = new(143, 73);
		public static readonly (int, int) BV18 = new(17, 73);
		public static readonly (int, int) BW144 = new(143, 74);
		public static readonly (int, int) BW18 = new(17, 74);
		public static readonly (int, int) C30 = new(29, 2);
		public static readonly (int, int) C31 = new(30, 2);
		public static readonly (int, int) C32 = new(31, 2);
		public static readonly (int, int) C33 = new(32, 2);
		public static readonly (int, int) C34 = new(33, 2);
		public static readonly (int, int) C45 = new(44, 2);
		public static readonly (int, int) C46 = new(45, 2);
		public static readonly (int, int) C49 = new(48, 2);
		public static readonly (int, int) C51 = new(50, 2);
		public static readonly (int, int) C56 = new(55, 2);
		public static readonly (int, int) C57 = new(56, 2);
		public static readonly (int, int) C58 = new(57, 2);
		public static readonly (int, int) C59 = new(58, 2);
		public static readonly (int, int) C71 = new(70, 2);
		public static readonly (int, int) C82 = new(81, 2);
		public static readonly (int, int) C83 = new(82, 2);
		public static readonly (int, int) C84 = new(83, 2);
		public static readonly (int, int) C85 = new(84, 2);
		public static readonly (int, int) F38 = new(37, 5);
		public static readonly (int, int) F49 = new(48, 5);
		public static readonly (int, int) F51 = new(50, 5);
		public static readonly (int, int) F59 = new(58, 5);
		public static readonly (int, int) F71 = new(70, 5);
		public static readonly (int, int) F82 = new(81, 5);
		public static readonly (int, int) F83 = new(82, 5);
		public static readonly (int, int) F84 = new(83, 5);
		public static readonly (int, int) F85 = new(84, 5);
		public static readonly (int, int) I19 = new(18, 8);
		public static readonly (int, int) I20 = new(19, 8);
		public static readonly (int, int) L144 = new(143, 11);
		public static readonly (int, int) L18 = new(17, 11);
		public static readonly (int, int) X144 = new(143, 23);
		public static readonly (int, int) X15 = new(14, 23);
		public static readonly (int, int) X18 = new(17, 23);
		public static readonly (int, int) X6 = new(5, 23);
		public static readonly (int, int) X8 = new(7, 23);
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
		public static readonly (int, int) Y142 = new(141, 24);
		public static readonly (int, int) Y143 = new(142, 24);
		public static readonly (int, int) Y144 = new(143, 24);
		public static readonly (int, int) Y15 = new(14, 24);
		public static readonly (int, int) Y18 = new(17, 24);
		public static readonly (int, int) Y6 = new(5, 24);
		public static readonly (int, int) Y8 = new(7, 24);
		public static readonly (int, int) Y83 = new(82, 24);
		public static readonly (int, int) Z144 = new(143, 25);
		public static readonly (int, int) Z15 = new(14, 25);
		public static readonly (int, int) Z18 = new(17, 25);
		public static readonly (int, int) Z6 = new(5, 25);
		public static readonly (int, int) Z8 = new(7, 25);
	}
}
