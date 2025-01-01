/*
Select dok.Doktorid, dok.DoktorAd, dok.Bransid, br.BransAd From Tbl_Doktorlar dok
left join Tbl_Branslar br on dok.Bransid=br.Bransid 
*/

Select ran.*, dok.DoktorAd,br.BransAd From Tbl_Randevular ran
left join Tbl_Doktorlar dok on dok.Doktorid= ran.Doktorid 
left join Tbl_Branslar br on br.Bransid=dok.Bransid
