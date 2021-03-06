dotnet JKO.dll REGISTER user1 
dotnet JKO.dll CREATE_LISTING user1 'Phone model 8' 'Black color, brand new' 1000 'Electronics' 
dotnet JKO.dll GET_LISTING user1 100001 
dotnet JKO.dll CREATE_LISTING user1 'Black shoes' 'Training shoes' 100 'Sports' 
dotnet JKO.dll REGISTER user2 
dotnet JKO.dll REGISTER user2 
dotnet JKO.dll CREATE_LISTING user2 'T-shirt' 'White color' 20 'Sports' 
dotnet JKO.dll GET_LISTING user1 100003 
dotnet JKO.dll GET_CATEGORY user1 'Fashion' sort_time asc 
dotnet JKO.dll GET_CATEGORY user1 'Sports' sort_time dsc 
dotnet JKO.dll GET_CATEGORY user1 'Sports' sort_price dsc 
dotnet JKO.dll GET_TOP_CATEGORY user1 
dotnet JKO.dll DELETE_LISTING user1 100003 
dotnet JKO.dll DELETE_LISTING user2 100003 
dotnet JKO.dll GET_TOP_CATEGORY user2 
dotnet JKO.dll DELETE_LISTING user1 100002 
dotnet JKO.dll GET_TOP_CATEGORY user1 
dotnet JKO.dll GET_TOP_CATEGORY user3 