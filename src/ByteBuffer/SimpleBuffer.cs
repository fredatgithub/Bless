// created on 6/29/2005 at 7:05 PM
/*
 *   Copyright (c) 2005, Alexandros Frantzis (alf82 [at] freemail [dot] gr)
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
using System;

namespace Bless.Buffers
{

///<summary>
/// A simple and lightweight buffer implementing the Buffer interface 
///</summary>
public class SimpleBuffer : Buffer
{
	byte[] data;
	
	public SimpleBuffer() 
	{
		data=new byte[0];
	}
	
	public override void Put(long pos, byte[] d) 
	{
		throw new NotImplementedException();
	}
	
	public override int Get(byte[] ba, long pos, int len) 
	{
		Array.Copy(data, pos, ba, 0, len);
		return len;
	}
	
	public override void Append(byte[] d) 
	{
		if (data.Length>0) {
			byte[] tmp=new byte[data.LongLength+d.LongLength];
			data.CopyTo(tmp, 0);
			d.CopyTo(tmp, data.LongLength);
			data=tmp;
		}
		else // just assign reference, this is more efficient
			// but could lead to problems if caller is not careful...
			data=d;
	}
	
	public override void Append(byte b) 
	{
			throw new NotImplementedException();	
	}
	
	public override byte this[long index] {
		set {
			if (index >= data.LongLength)
				return;
			data[index]=value;	
		 }
		 
		get {
			if (index >= data.LongLength)
				return 0;
			return data[index];
		}
	}

	public override long Size {
		get { return data.LongLength; }
	}
	
}

} // end namespace
 