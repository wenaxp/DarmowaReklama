ALTER PROCEDURE AdvertisementPagging
   @TotalPages INT OUTPUT,
   @PageNo INT = 1,
   @PageSize INT = 10,
   --Age,Weight,BustSize,Price1h,Price30min,Price15min,PriceAllNight
   @SortColumn NVARCHAR(20) = 'Date',
   @SortOrder NVARCHAR(4)='ASC',
   --filter
   @CityId INT= NULL,
   @VoivodeshipId INT=NULL,
   @AgeFrom INT=NULL,
   @AgeTo INT=NULL,
   @WeightFrom INT=NULL,
   @WeightTo INT=NULL,
   @BustSizeFrom int=null,
   @BustSizeTo int=null,
   @English bit=null,
   @German bit=null,
   @Russian bit=null,
   @Price1hFrom int=null,
   @Price1hTo int=null,
   @Price30minFrom int=null,
   @Price30minTo int=null,
   @Price15minFrom int=null,
   @Price15minTo int=null,
   @PriceAllNightFrom int=null,
   @PriceAllNightTo int=null,
   @OutCallsId int=null
AS
BEGIN
    select @TotalPages = (count(id)/@PageSize) from Advertisement;
	DECLARE 
        @lFirstRec INT,
        @lLastRec INT


    SET @lFirstRec = ( @PageNo - 1 ) * @PageSize
    SET @lLastRec = ( @PageNo * @PageSize + 1 )

    ; WITH CTE_Results
    AS (
    select 
        ROW_NUMBER() over (order by 
        CASE WHEN (@SortColumn = 'Age')
        THEN Age
        END,
        CASE WHEN (@SortColumn = 'Weight')
        THEN Weight
        END,
        CASE WHEN (@SortColumn = 'BustSize')
        THEN BustSize
        END,
        CASE WHEN (@SortColumn = 'Price1h')
        THEN Price1h
        END,
        CASE WHEN (@SortColumn = 'Price30min')
        THEN Price30min
        END,
        CASE WHEN (@SortColumn = 'Price15min')
        THEN Price15min
        END,
        CASE WHEN (@SortColumn = 'PriceAllNight')
        THEN PriceAllNight
        END
        ) ROWNUM,
        *
    from Advertisement
    where
        (@CityId is null or CityId=@CityId)
        and (@VoivodeshipId is null or VoivodeshipId=@VoivodeshipId)
        and (@AgeFrom is null or Age>=@AgeFrom)
        and (@AgeTo is null or Age<=@AgeTo)
        and (@WeightFrom is null or Weight>=@WeightFrom)
        and (@WeightTo is null or Weight<=@WeightTo)
        and (@BustSizeFrom is null or BustSize>=@BustSizeFrom)
		and (@BustSizeTo is null or BustSize<=@BustSizeTo)
        and (@English is null or English=@English)
        and (@German is null or German=@German)
        and (@Russian is null or Russian=@Russian)
        and (@Price1hFrom is null or Price1h>=@Price1hFrom)
        and (@Price1hTo is null or Price1h<=@Price1hFrom)
        and (@Price30minFrom is null or Price30min>=@Price30minFrom)
        and (@Price30minTo is null or Price30min<=@Price30minTo)
        and (@Price15minFrom is null or Price15min>=@Price15minFrom)
        and (@Price15minTo is null or Price15min<=@Price15minTo)
        and (@PriceAllNightFrom is null or PriceAllNight>=@PriceAllNightFrom)
        and (@PriceAllNightTo is null or PriceAllNight>=@PriceAllNightTo)
        and (@OutCallsId is null or OutCallsId=@OutCallsId)
    )

    SELECT
	    Id,Password,Name,CityId,CityName,VoivodeshipId,VoivodeshipName,Address,Email,Telephone,Age,Weight,BustSize,English,German,Russian,Price1h,Price30min,Price15min,PriceAllNight,OutCallsId,MonFrom,MonTo,TueFrom,TueTo,WedFrom,WedTo,ThuFrom,ThuTo,FriFrom,FroTo,SatFrom,SatTo,SunFrom,SunTo,ContentPL,ContentEN,ContentDE,ContentRU,PublicId,Date
    FROM CTE_Results AS CPC
    WHERE
        ROWNUM > @lFirstRec
        AND ROWNUM < @lLastRec
	ORDER BY ROWNUM ASC

END