﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using ProjectZ.InGame.Controls;
using ProjectZ.InGame.Interface;
using ProjectZ.InGame.Overlay;
using ProjectZ.InGame.Things;

namespace ProjectZ.InGame.Pages
{
    class GameSettingsPage : InterfacePage
    {
        private readonly InterfaceListLayout _bottomBar;
        private DateTime _nextControlCheck = DateTime.MinValue;

        public GameSettingsPage(int width, int height)
        {
            // graphic settings layout
            var gameSettingsList = new InterfaceListLayout { Size = new Point(width, height), Selectable = true };
            var buttonWidth = 240;

            gameSettingsList.AddElement(new InterfaceLabel(Resources.GameHeaderFont, "settings_game_header",
                new Point(buttonWidth, (int)(height * Values.MenuHeaderSize)), new Point(0, 0)));

            var contentLayout = new InterfaceListLayout { Size = new Point(width, (int)(height * Values.MenuContentSize)), Selectable = true, ContentAlignment = InterfaceElement.Gravities.Top };

            contentLayout.AddElement(new InterfaceButton(new Point(buttonWidth, 18), new Point(0, 2), "settings_game_language", PressButtonLanguageChange));

            var toggleAutosave = InterfaceToggle.GetToggleButton(new Point(buttonWidth, 18), new Point(5, 2),
                "settings_game_autosave", GameSettings.Autosave, newState => { GameSettings.Autosave = newState; });
            contentLayout.AddElement(toggleAutosave);

            var toggleItemSlotSide = InterfaceToggle.GetToggleButton(new Point(buttonWidth, 18), new Point(5, 2),
                "settings_game_items_on_right", GameSettings.ItemsOnRight, newState => { GameSettings.ItemsOnRight = newState; });
            contentLayout.AddElement(toggleItemSlotSide);

            var swapButtons = InterfaceToggle.GetToggleButton(
                new Point(buttonWidth, 18),
                new Point(5, 2),
                "settings_game_swap_buttons",
                GameSettings.SwapButtons,
                newState =>
                {
                    _nextControlCheck = DateTime.Now.AddMilliseconds(500); // Small delay to prevent menu close on change
                    GameSettings.SwapButtons = newState;
                    ControlHandler.SetConfirmCancelButtons();
                    InventoryOverlay.UpdateItemSlotStrings();
                    Game1.UiPageManager.UpdateControlSettingsPage();
                }
            );
            contentLayout.AddElement(swapButtons);

            gameSettingsList.AddElement(contentLayout);

            _bottomBar = new InterfaceListLayout() { Size = new Point(width, (int)(height * Values.MenuFooterSize)), Selectable = true, HorizontalMode = true };
            // back button
            _bottomBar.AddElement(new InterfaceButton(new Point(60, 20), new Point(2, 4), "settings_menu_back", element =>
            {
                Game1.UiPageManager.PopPage();
            }));

            gameSettingsList.AddElement(_bottomBar);

            PageLayout = gameSettingsList;
        }

        public override void Update(CButtons pressedButtons, GameTime gameTime)
        {
            base.Update(pressedButtons, gameTime);

            // close the page
            if (_nextControlCheck <= DateTime.Now && ControlHandler.ButtonPressed(ControlHandler.CancelButton))
                Game1.UiPageManager.PopPage();
        }

        public override void OnLoad(Dictionary<string, object> intent)
        {
            // the left button is always the first one selected
            _bottomBar.Deselect(false);
            _bottomBar.Select(InterfaceElement.Directions.Left, false);
            _bottomBar.Deselect(false);

            PageLayout.Deselect(false);
            PageLayout.Select(InterfaceElement.Directions.Top, false);
        }

        public void PressButtonLanguageChange(InterfaceElement element)
        {
            Game1.LanguageManager.ToggleLanguage();
        }
    }
}
