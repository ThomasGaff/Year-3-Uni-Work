select r.track, to_char(r.month, 'Month') Month, NVL2(rt.race_number, 'Yes', 'No' ) Race_took_place, round(avg(to_char(rt.finish_time,'sssss')),2) Average_Finish_Time
from race r
FULL JOIN result rt
ON r.race_number = rt.race_number
group by r.track, r.month, rt.race_number, r.race_number
