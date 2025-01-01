-- ================================================
-- Template generated from Template Explorer using:
-- Create Trigger (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- See additional Create Trigger templates for more
-- examples of different Trigger statements.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Alter TRIGGER Tbl_Randevular_insert 
   ON  Tbl_Randevular
   AFTER insert
AS 
BEGIN
declare @doktorid int
declare @muanesayisi int

select @doktorid = Doktorid From inserted
select @muanesayisi= MuaneSayisi From Tbl_Doktorlar Where Doktorid=@doktorid
	SET NOCOUNT ON;
	update Tbl_Doktorlar set MuaneSayisi= isnull(@muanesayisi,0)+1 Where Doktorid=@doktorid
    -- Insert statements for trigger here

END
GO
