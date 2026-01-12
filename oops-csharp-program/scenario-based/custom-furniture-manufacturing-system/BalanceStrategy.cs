namespace CustomFurtnitureManufacturing
{
    internal class BalanceStrategy : CutStrategy
    {
        public override int CalculateResult(WoodRod rod)
        {
            return BalancedCut(rod, rod.GetWoodRodSize());
        }

        private int BalancedCut(WoodRod rod, int remaining)
        {
            if (remaining == 0)
                return 0;

            int bestScore = 0;

            for (int cut = 1; cut <= remaining; cut++)
            {
                int wastePenalty = (remaining - cut <= 1) ? 2 : 0;

                int score =
                    rod.GetWoodRodPrice(cut)
                    - wastePenalty
                    + BalancedCut(rod, remaining - cut);

                if (score > bestScore)
                    bestScore = score;
            }

            return bestScore;
        }
    }
}
