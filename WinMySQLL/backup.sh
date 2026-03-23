MYSQL_CONTAINER="mysql_server"
DB_NAME="escolar"
DB_ROOT_PASS="Luna115115"
LOCAL_BACKUP_DIR="./backup" 

TIMESTAMP=$(date +"%Y%m%d%H%M%S")
BACKUP_FILE="${LOCAL_BACKUP_DIR}/${DB_NAME}_backup_${TIMESTAMP}.sql"

echo "Creating backup directory if it doesn't exist..."
echo "Backup directory: ${LOCAL_BACKUP_DIR}"
echo ""

mkdir -p "${LOCAL_BACKUP_DIR}"  

echo "[1/1] Creando respaldo de la base de datos '${DB_NAME}'..."
docker exec "$MYSQL_CONTAINER" mysqldump -u root -p"$DB_ROOT_PASS" "$DB_NAME" > "$BACKUP_FILE"

if [ $? -eq 0 ]; then
    echo "Respaldo creado exitosamente: ${BACKUP_FILE}"
else
    echo "Error al crear el respaldo."
fi

echo "Proceso de respaldo finalizado."
echo "Archivo de respaldo: ${BACKUP_FILE}"


