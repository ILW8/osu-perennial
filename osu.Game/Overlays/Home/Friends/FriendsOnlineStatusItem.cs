﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using osu.Game.Graphics;
using osuTK.Graphics;

namespace osu.Game.Overlays.Home.Friends
{
    public class FriendsOnlineStatusItem : OverlayUpdateStreamItem<FriendsBundle>
    {
        public FriendsOnlineStatusItem(FriendsBundle value)
            : base(value)
        {
        }

        protected override string GetMainText => Value.Status.ToString();

        protected override string GetAdditionalText => Value.Count.ToString();

        protected override Color4 GetBarColour(OsuColour colours)
        {
            switch (Value.Status)
            {
                default:
                    throw new ArgumentException($@"{Value.Status} status does not provide a colour in {nameof(GetBarColour)}.");

                case FriendsOnlineStatus.All:
                    return Color4.White;

                case FriendsOnlineStatus.Online:
                    return colours.GreenLight;

                case FriendsOnlineStatus.Offline:
                    return Color4.Black;
            }
        }
    }
}
