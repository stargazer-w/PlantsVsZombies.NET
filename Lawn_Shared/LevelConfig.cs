using Lawn;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lawn_Shared
{
    public class LevelConfig
    {
        public int SumMoney { get; set; } = 50;

        public PlantRowType[] PlantRows { get; set; } = [PlantRowType.Normal, PlantRowType.Normal, PlantRowType.Normal, PlantRowType.Normal, PlantRowType.Normal, PlantRowType.Dirt];

        public Action<Board> OnCoinAdd { get; set; } = delegate { };

        public TutorialState? TutorialState { get; set; }

        public static LevelConfig Adventure1 { get; set; } = new()
        {
            SumMoney = 150,
            OnCoinAdd = board => board.DisplayAdvice("[ADVICE_CLICK_ON_SUN]", MessageStyle.TutorialLevel1Stay, AdviceType.ClickOnSun),
            PlantRows = [PlantRowType.Dirt, PlantRowType.Dirt, PlantRowType.Normal, PlantRowType.Dirt, PlantRowType.Dirt, PlantRowType.Dirt]
            TutorialState = TutorialState.Level1PickUpPeashooter,

        };
    }
}
