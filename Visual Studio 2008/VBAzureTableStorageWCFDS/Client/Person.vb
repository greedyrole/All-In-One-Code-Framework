'****************************** Module Header ******************************\
' Module Name:	Person.vb
' Project:		VBAzureTableStorageWCFDS
' Copyright (c) Microsoft Corporation.
' 
' This is a partical class for the Person class generated by WCF Data Services reference.
' 
' This source is subject to the Microsoft Public License.
' See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
' All other rights reserved.
' 
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
' EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
' WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
'***************************************************************************/

Namespace DataServiceReference
	Partial Public Class Person
		' By default, when creating a new entity, the PartitionKey is set to the current year, and the RowKey is a GUID. Insert the ticks in the beginning of RowKey because the result returned by a query is ordered by PartitionKey and then RowKey.
		Public Sub New()
			MyBase.PartitionKey = DateTime.UtcNow.ToString("yyyy")
			MyBase.RowKey = String.Format("{0:10}_{1}", (DateTime.MaxValue.Ticks - DateTime.Now.Ticks), Guid.NewGuid)
		End Sub

		Public Sub New(ByVal partitionKey As String, ByVal rowKey As String)
			MyBase.PartitionKey = partitionKey
			MyBase.RowKey = rowKey
		End Sub
	End Class
End Namespace