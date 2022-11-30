//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.11.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from DUN.g4 by ANTLR 4.11.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.11.1")]
[System.CLSCompliant(false)]
public partial class DUNParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		Number=1, Identifier=2, Equals=3, Whitespace=4, Newline=5;
	public const int
		RULE_file = 0, RULE_assignment = 1;
	public static readonly string[] ruleNames = {
		"file", "assignment"
	};

	private static readonly string[] _LiteralNames = {
		null, null, null, "'='"
	};
	private static readonly string[] _SymbolicNames = {
		null, "Number", "Identifier", "Equals", "Whitespace", "Newline"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "DUN.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static DUNParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public DUNParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public DUNParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class FileContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentContext assignment() {
			return GetRuleContext<AssignmentContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(DUNParser.Eof, 0); }
		public FileContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_file; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IDUNListener typedListener = listener as IDUNListener;
			if (typedListener != null) typedListener.EnterFile(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IDUNListener typedListener = listener as IDUNListener;
			if (typedListener != null) typedListener.ExitFile(this);
		}
	}

	[RuleVersion(0)]
	public FileContext file() {
		FileContext _localctx = new FileContext(Context, State);
		EnterRule(_localctx, 0, RULE_file);
		try {
			State = 8;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case Identifier:
				EnterOuterAlt(_localctx, 1);
				{
				State = 4;
				assignment();
				 UnityEngine.Debug.Log("Antlr4 read this"); 
				}
				break;
			case Eof:
				EnterOuterAlt(_localctx, 2);
				{
				State = 7;
				Match(Eof);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AssignmentContext : ParserRuleContext {
		public IToken _Identifier;
		public IToken _Equals;
		public IToken _Number;
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(DUNParser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Equals() { return GetToken(DUNParser.Equals, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Number() { return GetToken(DUNParser.Number, 0); }
		public AssignmentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_assignment; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IDUNListener typedListener = listener as IDUNListener;
			if (typedListener != null) typedListener.EnterAssignment(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IDUNListener typedListener = listener as IDUNListener;
			if (typedListener != null) typedListener.ExitAssignment(this);
		}
	}

	[RuleVersion(0)]
	public AssignmentContext assignment() {
		AssignmentContext _localctx = new AssignmentContext(Context, State);
		EnterRule(_localctx, 2, RULE_assignment);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 10;
			_localctx._Identifier = Match(Identifier);
			State = 11;
			_localctx._Equals = Match(Equals);
			State = 12;
			_localctx._Number = Match(Number);
			 UnityEngine.Debug.Log("assignment" + (_localctx._Identifier!=null?_localctx._Identifier.Text:null) + (_localctx._Equals!=null?_localctx._Equals.Text:null) + (_localctx._Number!=null?_localctx._Number.Text:null)); 
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static int[] _serializedATN = {
		4,1,5,16,2,0,7,0,2,1,7,1,1,0,1,0,1,0,1,0,3,0,9,8,0,1,1,1,1,1,1,1,1,1,1,
		1,1,0,0,2,0,2,0,0,14,0,8,1,0,0,0,2,10,1,0,0,0,4,5,3,2,1,0,5,6,6,0,-1,0,
		6,9,1,0,0,0,7,9,5,0,0,1,8,4,1,0,0,0,8,7,1,0,0,0,9,1,1,0,0,0,10,11,5,2,
		0,0,11,12,5,3,0,0,12,13,5,1,0,0,13,14,6,1,-1,0,14,3,1,0,0,0,1,8
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}