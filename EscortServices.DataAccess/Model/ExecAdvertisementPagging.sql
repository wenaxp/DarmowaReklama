declare @TotalPages int

exec AdvertisementPagging @TotalPages=@TotalPages output

select @TotalPages