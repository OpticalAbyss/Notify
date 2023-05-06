using Microsoft.EntityFrameworkCore.Migrations;

namespace NotifyWebApp.Migrations
{
    public partial class fix1ForiegnKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ArtistID",
                table: "Tracks",
                newName: "Artist_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_Artist_ID",
                table: "Tracks",
                column: "Artist_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Artists_Artist_ID",
                table: "Tracks",
                column: "Artist_ID",
                principalTable: "Artists",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Artists_Artist_ID",
                table: "Tracks");

            migrationBuilder.DropIndex(
                name: "IX_Tracks_Artist_ID",
                table: "Tracks");

            migrationBuilder.RenameColumn(
                name: "Artist_ID",
                table: "Tracks",
                newName: "ArtistID");
        }
    }
}
