﻿namespace BitPoker.Logic.Players
{
	using System.Collections.Generic;
	using BitPoker.Models;
	using BitPoker.Models.Cards;

	public class StartRoundContext
    {
        public StartRoundContext(GameRoundType roundType, IReadOnlyCollection<Card> communityCards, int moneyLeft, int currentPot)
        {
            this.RoundType = roundType;
            this.CommunityCards = communityCards;
            this.MoneyLeft = moneyLeft;
            this.CurrentPot = currentPot;
        }

        public GameRoundType RoundType { get; }

        public IReadOnlyCollection<Card> CommunityCards { get; }

        public int MoneyLeft { get; }

        public int CurrentPot { get; }
    }
}
