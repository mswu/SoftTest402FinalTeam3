﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftTest402FinalTeam3
{
    class TedNPadHelper
    {
        public static void ClickEditSelectAllMenuItem(IntPtr mainWindowHandle)
        {
            Helper.ClickMenuItem(
                mainWindowHandle,
                (int)TedNPadConstant.MainMenu.Edit,
                (int)TedNPadConstant.EditSubMenu.SelectAll);
        }

        public static void ClickEditCopyMenuItem(IntPtr mainWindowHandle)
        {
            Helper.ClickMenuItem(
                mainWindowHandle,
                (int)TedNPadConstant.MainMenu.Edit,
                (int)TedNPadConstant.EditSubMenu.Copy);
        }

        public static void ClickEditPasteMenuItem(IntPtr mainWindowHandle)
        {
            Helper.ClickMenuItem(
                mainWindowHandle,
                (int)TedNPadConstant.MainMenu.Edit,
                (int)TedNPadConstant.EditSubMenu.Paste);
        }

        public static void ClickSmartReturnMenuItem(IntPtr mainWindowHandle)
        {
            Helper.ClickMenuItem(
                mainWindowHandle,
                (int)TedNPadConstant.MainMenu.Edit,
                (int)TedNPadConstant.EditSubMenu.SmartReturn);
        }

        public static void ClickInsertTimeDateSubMenuItem(IntPtr mainWindowHandle)
        {
            Helper.ClickSubMenuItem(mainWindowHandle,
                                 (int)TedNPadConstant.MainMenu.Edit,
                                 (int)TedNPadConstant.EditSubMenu.Insert,
                                 (int)TedNPadConstant.EditInsertMenu.TimeDate);
        }

        public static void ClickInsertDateSubMenuItem(IntPtr mainWindowHandle)
        {
            Helper.ClickSubMenuItem(mainWindowHandle,
                                 (int)TedNPadConstant.MainMenu.Edit,
                                 (int)TedNPadConstant.EditSubMenu.Insert,
                                 (int)TedNPadConstant.EditInsertMenu.Date);
        }
    }
}
