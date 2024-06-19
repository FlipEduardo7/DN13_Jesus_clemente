/*Script de select de country con inner join a City filtrando por identificador de país*/
SELECT ci.city_id, ci.country_id, ci.last_update FROM country co 
inner join city ci on co.country_id = ci.country_id
where co.country_id = 2;

/*Script de select de film con agrupación por name, rating y total_films*/
select 
	c.name,
    sub.rating,
    sub.total_films
from film f
inner join film_category fc on f.film_id = fc.film_id
inner join category c on fc.category_id = c.category_id
inner join 
(
	select
		count(*) total_films,
        rating from film f
	group by rating having count(*) > 200
) sub on f.rating = sub.rating

/*Script de union de max y min*/
select 
	'Mayor cantidad' query_type,
	sub2.total_films,
    a.actor_id,
    a.first_name,
    a.last_name
 from
(
	select max(total_films) max_films
	from 
	(
		SELECT 
			count(*) total_films, 
			actor_id FROM film_actor
		group by actor_id
	) sub
) sub_max
inner join
(
	SELECT 
		count(*) total_films, 
		actor_id FROM film_actor
	group by actor_id
)sub2 on sub_max.max_films = sub2.total_films
inner join actor a on a.actor_id = sub2.actor_id

union

select 
	'Menor cantidad' query_type,
	sub2.total_films,
    a.actor_id,
    a.first_name,
    a.last_name
 from
(
	select min(total_films) max_films
	from 
	(
		SELECT 
			count(*) total_films, 
			actor_id FROM film_actor
		group by actor_id
	) sub
) sub_max
inner join
(
	SELECT 
		count(*) total_films, 
		actor_id FROM film_actor
	group by actor_id
)sub2 on sub_max.max_films = sub2.total_films
inner join actor a on a.actor_id = sub2.actor_id