namespace Bowling
{
    /// <summary>
    /// Represents a bowling game and provides functionality to calculate the score.
    /// </summary>
    public class BowlingGame
    {
        private const int StrikeScore = 10;
        private const int SpareScore = 10;
        private const int MissScore = 0;
        private const int MaxFrames = 10;
        private const int FrameRolls = 2;

        private static bool IsStrike(string frame) => frame == "X";

        private static bool IsSpare(string frame) => frame.Length == FrameRolls && frame[1] == '/';

        /// <summary>
        /// Calculates the total score for a given sequence of rolls.
        /// </summary>
        /// <param name="rolls">The sequence of rolls in a single string.</param>
        /// <returns>The total score for the game.</returns>
        /// <exception cref="ArgumentException">Thrown when an invalid roll character is encountered.</exception>
        public int GetScore(string rolls)
        {
            int score = 0;
            var frames = rolls.Split(' ');

            for (
                int frameIndex = 0;
                frameIndex < frames.Length && frameIndex < MaxFrames;
                frameIndex++
            )
            {
                var fullFrame = frames[frameIndex];
                var frame = fullFrame[..Math.Min(FrameRolls, fullFrame.Length)];

                score += CalculateFrameScore(frames, frameIndex, frame);

                // Handle bonus rolls in the 10th frame
                if (frameIndex == MaxFrames - 1 && fullFrame.Length > FrameRolls)
                {
                    score += CalculateBonusRolls(fullFrame);
                }
            }

            return score;
        }

        private int CalculateFrameScore(string[] frames, int frameIndex, string frame)
        {
            if (IsStrike(frame))
            {
                return CalculateStrikeScore(frames, frameIndex);
            }

            if (IsSpare(frame))
            {
                return CalculateSpareScore(frames, frameIndex);
            }

            return CalculateNormalFrameScore(frame);
        }

        private int CalculateStrikeScore(string[] frames, int frameIndex)
        {
            if (frameIndex + 1 >= frames.Length)
            {
                return StrikeScore;
            }

            int score = StrikeScore;

            var nextFrame = frames[frameIndex + 1];
            score += GetRollValue(nextFrame[0]);

            if (nextFrame.Length > 1 && nextFrame[1] == '/')
            {
                score += SpareScore - GetRollValue(nextFrame[0]);
            }
            else if (nextFrame.Length > 1)
            {
                score += GetRollValue(nextFrame[1]);
            }
            else if (frameIndex + 2 < frames.Length)
            {
                var frameAfterNext = frames[frameIndex + 2];
                score += GetRollValue(frameAfterNext[0]);
            }

            return score;
        }

        private int CalculateSpareScore(string[] frames, int frameIndex)
        {
            if (frameIndex + 1 >= frames.Length)
            {
                return SpareScore;
            }

            int score = SpareScore;
            var nextFrame = frames[frameIndex + 1];
            score += GetRollValue(nextFrame[0]);
            return score;
        }

        private int CalculateNormalFrameScore(string frame)
        {
            return frame.Sum(GetRollValue);
        }

        private int CalculateBonusRolls(string fullFrame)
        {
            return fullFrame.Skip(FrameRolls).Select(GetRollValue).Sum();
        }

        private int GetRollValue(char roll)
        {
            return roll switch
            {
                'X' => StrikeScore,
                '/' => SpareScore,
                '-' => MissScore,
                _ when char.IsDigit(roll) => int.Parse(roll.ToString()),
                _ => throw new ArgumentException($"Invalid roll character: {roll}")
            };
        }
    }
}
