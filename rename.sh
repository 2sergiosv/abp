# 批量修改项目名称，包括：目录、文件、命名空间
VERSION=0.0.1
PROGNAME="$(basename $0)"
BASEPATH=""
FROM=""
TO=""

usage() {
	echo "批量修改项目名称，包括：目录、文件、命名空间"
	echo
    echo "Usage: "$PROGNAME" [options] [option-arg]"   
    echo
	echo "  -h              Show this help"
    echo "  -v              Print version number"
	echo "  -c            	Apply changes"
	echo "  -p            	Base path"
	echo "  -f            	Old name"
	echo "  -t            	New name"
    echo "Examples:"
    echo "  "$PROGNAME" -c YkAbp K9Abp"
}

# git bash does not support rename.
rename() {	
	newName=`echo $1|sed "s/$FROM/$TO/g"`
	mv $1 $newName
}

changeFileContent() {
	echo "change file content: $1 "
	sed -i "s/${FROM}/${TO}/g" $1 
}

changeFileName() {
	echo "change file name: $1 "
	fileName=$(basename $1)	
	rename $fileName
}

getPathAndFiles() {	
	for file in $(ls $1)
	do
		file=$1/$file
		if [ -d $file ]
		then
			getPathAndFiles $file	
		else
			changeFileContent $file
		fi
		changeFileName $file
	done
}

changeName() {	
	getPathAndFiles $BASEPATH
}	

needChange=0
while getopts 'hvp:f:t:c' opt; 
do	
    case ${opt} in
        h)
			usage
			exit 0
			;;
        v)
            echo $VERSION
            exit 0
            ;;
		p)
			BASEPATH=$(cd `dirname ${OPTARG}/`; pwd)/"${OPTARG}"
			;;
		f)
			FROM="${OPTARG}"
			;;
		t)
			TO="${OPTARG}"
			;;
		c) 
			needChange=1
			;;
        ?)
            usage
			exit 1
			;;
    esac
done

if [ $needChange -eq 1 ]
then
	changeName
fi
