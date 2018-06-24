select d.driver_id, count(r.driver_id) Num_of_races, round(avg(r.finish_position),2), round(avg(r.points),2), d.team_no, d.lastname, d.firstname, d.country
from driver d, result r
where d.driver_id = r.driver_id
group by d.driver_id, d.team_no, d.lastname, d.firstname, d.country