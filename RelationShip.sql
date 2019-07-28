


-- referancing Tables 
alter table Comment
add foreign key (PostId) references Post(Id);
