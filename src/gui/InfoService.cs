// created on 4/30/2006 at 12:00 PM
/*
 *   Copyright (c) 2006, Alexandros Frantzis (alf82 [at] freemail [dot] gr)
 *
 *   This file is part of Bless.
 *
 *   Bless is free software; you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation; either version 2 of the License, or
 *   (at your option) any later version.
 *
 *   Bless is distributed in the hope that it will be useful,
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *   GNU General Public License for more details.
 *
 *   You should have received a copy of the GNU General Public License
 *   along with Bless; if not, write to the Free Software
 *   Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */
using Bless.Tools;
 
namespace Bless.Gui
{
	
public interface IInfoDisplay
{
	void DisplayMessage(string message);
	void ClearMessage();
}

public class InfoService
{
	IInfoDisplay infoDisplay;
	
	public InfoService(IInfoDisplay id)
	{
		infoDisplay=id;
	}
	
	///<summary>Displays a message in the infobar (for 5 sec)</summary>
	public void DisplayMessage(string message)
	{
		infoDisplay.DisplayMessage(message);
	}
	
	///<summary>
	/// Clears the information displayed in the infobar
	///</summary>
	public void ClearMessage()
	{
		infoDisplay.ClearMessage();
	}
	
}

}	