echo find and Replace

set -e
ls
[ -f $3 ] && echo "File exist" || echo "File does not exist"

echo String To find: $1
echo String To Replace with: $2
echo File to Replace In: $3

sed -i -e "s/$1/$2/g" $3