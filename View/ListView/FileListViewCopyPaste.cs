﻿using System;
using System.Windows.Forms;
using GeoTagNinja.Helpers;
using GeoTagNinja.Model;
using GeoTagNinja.View.DialogAndMessageBoxes;
using static GeoTagNinja.Helpers.HelperControlAndMessageBoxHandling;
using static GeoTagNinja.Model.SourcesAndAttributes;

namespace GeoTagNinja.View.ListView;

internal static class FileListViewCopyPaste
{
    /// <summary>
    ///     This drives the logic for "copying" (as in copy-paste) the geodata from one file to others.
    /// </summary>
    internal static void ListViewCopyGeoData()
    {
        FrmMainApp frmMainAppInstance =
            (FrmMainApp)Application.OpenForms[name: "FrmMainApp"];
        if (frmMainAppInstance.lvw_FileList.SelectedItems.Count == 1)
        {
            ListViewItem lvi = frmMainAppInstance.lvw_FileList.SelectedItems[index: 0];

            // don't copy folders....
            DirectoryElement dirElemFileToCopyFrom =
                lvi.Tag as DirectoryElement;
            if (dirElemFileToCopyFrom.Type == DirectoryElement.ElementType.File)
            {
                // The reason why we're using a CopyPoolDict here rather than just read straight out of the DE is because if the user changes folder
                // ... then the DE-data would be cleared and thus cross-folder-paste wouldn't be possible
                FrmMainApp.CopyPoolDict.Clear();

                foreach (ElementAttribute attribute in HelperGenericAncillaryListsArrays.TagsToCopy)
                {
                    // this would sit in Stage3ReadyToWrite if exists
                    if (dirElemFileToCopyFrom.HasSpecificAttributeWithVersion(
                            attribute: attribute,
                            version: DirectoryElement.AttributeVersion
                                                     .Stage3ReadyToWrite))
                    {
                        FrmMainApp.CopyPoolDict.Add(key: attribute,
                                                    value: new Tuple<string, bool>(
                                                        item1: dirElemFileToCopyFrom
                                                           .GetAttributeValueString(
                                                                attribute: attribute,
                                                                version: DirectoryElement.AttributeVersion
                                                                   .Stage3ReadyToWrite,
                                                                nowSavingExif: false),
                                                        item2: true));
                    }
                    else if (dirElemFileToCopyFrom.HasSpecificAttributeWithVersion(
                                 attribute: attribute,
                                 version: DirectoryElement.AttributeVersion.Original))
                    {
                        FrmMainApp.CopyPoolDict.Add(key: attribute,
                                                    value: new Tuple<string, bool>(
                                                        item1: dirElemFileToCopyFrom
                                                           .GetAttributeValueString(
                                                                attribute: attribute,
                                                                version: DirectoryElement.AttributeVersion
                                                                   .Original,
                                                                nowSavingExif: false),
                                                        item2: false));
                    }
                }
            }
        }
        else
        {
            CustomMessageBox customMessageBox = new(
                text: ReturnControlText(
                    controlName: "mbx_Helper_WarningTooManyFilesSelected",
                    fakeControlType: FakeControlTypes.MessageBox),
                caption: ReturnControlText(
                    controlName: MessageBoxCaption
                                .Warning.ToString(), fakeControlType: FakeControlTypes.MessageBoxCaption),
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Warning);
            customMessageBox.ShowDialog();
        }
    }

    /// <summary>
    ///     This drives the logic for "pasting" (as in copy-paste) the geodata from one file to others.
    ///     See further comments inside
    /// </summary>
    internal static void ListViewPasteGeoData()
    {
        FrmMainApp frmMainAppInstance =
            (FrmMainApp)Application.OpenForms[name: "FrmMainApp"];
        // check there's anything in copy-pool
        if (FrmMainApp.CopyPoolDict.Count > 0 &&
            frmMainAppInstance != null)
        {
            FrmPasteWhat frmPasteWhat = new(initiator: frmMainAppInstance.Name);
            frmPasteWhat.StartPosition = FormStartPosition.CenterScreen;
            frmPasteWhat.ShowDialog();
        }
        else
        {
            CustomMessageBox customMessageBox = new(
                text: ReturnControlText(
                    controlName: "mbx_Helper_WarningNothingToPaste",
                    fakeControlType: FakeControlTypes.MessageBox),
                caption: ReturnControlText(
                    controlName: MessageBoxCaption
                                .Warning.ToString(), fakeControlType: FakeControlTypes.MessageBoxCaption),
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Warning);
            customMessageBox.ShowDialog();
        }
    }
}