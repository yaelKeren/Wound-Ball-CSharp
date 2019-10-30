using System.Diagnostics.SymbolStore;

namespace BullsEyeLogic
{
    namespace Constance
    {
        public class Constance
        {
            public class GameManagerConsts
            {
                public const int k_MinNumOfGuess = 4;
                public const int k_MaxNumOfGuess = 10;
                public const int k_SequenceLen = 4;
                public const string k_SuccessGuess = "VVVV";
            }

            public class BoardLogicConsts
            {
                public const int k_Skip = 2;
                public const int k_NumOfCols = 2;
                public const string k_EncodedComputerSequence = "####";
                public const string k_EmptyCell = "    ";
            }

            public class GeneralConsts
            {
                public const int k_AsciiRangeBeginning = 65;
                public const int k_AsciiRangeEnding = 72;
                public const int k_One = 1;
                public const int k_Zero = 0;
                public const string k_RangeBeginning = "A";
                public const string k_RangeEnding = "H";
                public const string k_Space = " ";
                public const string k_Exit = "Q";
                public const string k_Yes = "Y";
                public const string k_No = "N";
                public const string k_Match = "V";
                public const string k_Exists = "X";
            }
        }
    }
}
